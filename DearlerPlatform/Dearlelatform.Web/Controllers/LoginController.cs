using DealerPlatform.Common.TokenModel;
using Dearlelatform.Web;
using DearlerPlatform.Service.CustomerApp;
using DearlerPlatform.Service.CustomerApp.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dearlelatform.Web.Controllers
{
    public class LoginController : BaseController
    {
        //注入服务层和配置文件
        public LoginController(ICustomerService customerService, IConfiguration configuration)
        {
            CustomerService = customerService;
            Configuration = configuration;
        }

        public ICustomerService CustomerService { get; }
        public IConfiguration Configuration { get; }


        /// <summary>
        /// 登录获得token
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<string> CheckLogin(CustomerLoginDto dto)
        {
            //判断传进来的值是否为null或者空格
            if (string.IsNullOrWhiteSpace(dto.CustomerNo) || string.IsNullOrWhiteSpace(dto.Password))
            {
                HttpContext.Response.StatusCode = 400;
                return "NonLoginInfo";
            }
            //判断登录是否正确
            var isSuccess = await CustomerService.CheckPassword(dto);

            if (isSuccess)
            {
                //如果正确就获得数据库中所对应用户的所有信息
                var customer = await CustomerService.GetCustomerAsync(dto.CustomerNo);
                //通过用户信息获得jwtToken并返回
                return GetToken(customer.Id, customer.CustomerNo, customer.CustomerName);
            }
            else 
            {
                HttpContext.Response.StatusCode = 400;
                return "NonUser";
            }
        }

        /// <summary>
        /// 根据用户信息返回JwtToken
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="customerNo"></param>
        /// <param name="customerName"></param>
        /// <returns></returns>
        private string GetToken(int customerId, string customerNo, string customerName)
        {
            //配置JwtToken模型并获得模型实例,添加模型数据
            var token = Configuration.GetSection("Jwt").Get<JwtTokenModel>();
            token.CustomerNo = customerNo;
            token.CustomerName = customerName;
            token.Id = customerId;
            //将token模型传入,返回token
            return TokenHelper.CreateToken(token);
        }
    }
}
