using DealerPlatform.Common.TokenModel;
using DearlerPlatform.Core;
using DearlerPlatform.Extensions;
using DearlerPlatform.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace Dearlelatform.Web.Extensions;

public static class WebApplicationBuilderExtensions
{
    public static void BuilderEnter(this IServiceCollection services)
    {
        //跨域
        services.AddCors(opt => opt.AddPolicy("any", o => { o.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod(); }));
        services.AddControllers();
        services.AddEndpointsApiExplorer();

        //swagger集成验证
        services.AddSwaggerGen(c => {
            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Description = "格式：Bearer {token}",
                Name = "Authorization", // 默认的参数名
                In = ParameterLocation.Header,// 放于请求头中
                Type = SecuritySchemeType.ApiKey,
                BearerFormat = "JWT",
                Scheme = "Bearer"
            });
            // 添加安全要求
            c.AddSecurityRequirement(new OpenApiSecurityRequirement{
                   {
                        new OpenApiSecurityScheme{
                             Reference = new OpenApiReference{
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    }, new string[]{}
                   }
                });
        });

        //获取数据库链接字符串
        var configuration = services.GetConfiguration();

        services.AddDbContext<DealerPlatformContext>(opt =>
        {
            opt.UseSqlServer(configuration.GetConnectionString("Default"));
        });

        var token = configuration.GetSection("Jwt").Get<JwtTokenModel>();
        #region Jwt验证
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer
        (
            opt =>
            {
                //是否https,默认为true,生产环境不要改为false
                opt.RequireHttpsMetadata = false;
                //是否存储token
                opt.SaveToken = true;
                //设置token参数
                opt.TokenValidationParameters = new()
                {
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(token.Security)),
                    ValidIssuer = token.Issuer,
                    ValidAudience = token.Audience
                };
                //处理token引发的事件
                opt.Events = new JwtBearerEvents
                {
                    OnChallenge = context =>
                    {
                        //此处终止代码
                        context.HandleResponse();
                        var res = "{\"Code\":203,\"err\":\"无权限\"}";
                        //返回类型为json
                        context.Response.ContentType = "application/json";
                        //设置错误代码
                        context.Response.StatusCode = StatusCodes.Status203NonAuthoritative;
                        context.Response.WriteAsync(res);
                        return Task.FromResult(0);
                    }
                };
            });
        #endregion

        //将automapper注册到容器中,并且添加实体映射类
        services.AddAutoMapper(typeof(DearlerPlatformProfile));

        services.RepositoryRegister();
        services.ServiceRegister();
    }

    /// <summary>
    /// 获得配置文件
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IConfiguration GetConfiguration(this IServiceCollection services)
    {
        var configration = services.BuildServiceProvider().GetService<IConfiguration>();
        return configration;
    }
}

