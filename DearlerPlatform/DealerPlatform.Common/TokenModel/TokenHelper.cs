using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace DealerPlatform.Common.TokenModel
{
    /// <summary>
    /// Token相关类
    /// </summary>
    public class TokenHelper
    {
        /// <summary>
        /// 创建包含有用户信息的Token并返回
        /// </summary>
        /// <param name="jwtToken">传入一个保存有相关信息的token模型</param>
        /// <returns></returns>
        public static string CreateToken(JwtTokenModel jwtToken)
        {
            //创建令牌相关信息
            var claims = new[] {
                new Claim("CustomerNo",jwtToken.CustomerNo),
                new Claim("Id",jwtToken.Id.ToString()),
                new Claim("CustomerName",jwtToken.CustomerName),

            };
            //生成密钥
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtToken.Security));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //将相关信息写入并创建
            var token = new JwtSecurityToken
             (
                   issuer: jwtToken.Issuer,
                   audience: jwtToken.Audience,
                   expires: DateTime.Now.AddMinutes(jwtToken.Expires),
                   signingCredentials: creds,
                   claims: claims
             );
            //序列化token
            var accessToken = new JwtSecurityTokenHandler().WriteToken(token);
            //返回token
            return accessToken;
        }
    }
}
