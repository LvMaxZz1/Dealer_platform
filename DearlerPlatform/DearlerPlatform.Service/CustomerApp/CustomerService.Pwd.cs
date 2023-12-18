using DealerPlatform.Common.Md5Model;
using DearlerPlatform.Core.Repository;
using DearlerPlatform.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearlerPlatform.Service.CustomerApp.DTO
{


    public partial class CustomerService 
    {
        /// <summary>
        /// 根据前端返回的视图模型判断数据库是否有当前用户
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public async Task<bool> CheckPassword(CustomerLoginDto dto)
        {
            var res = await CustomerPwdRepo.GetAsync(m => m.CustomerNo == dto.CustomerNo && m.CustomerPwd1 == dto.Password.ToMd5());
            if (res != null)
            {
                return true;
            }
            return false;
        }
    }
}
