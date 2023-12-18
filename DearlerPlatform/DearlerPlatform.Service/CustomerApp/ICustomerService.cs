using DearlerPlatform.Domain;
using DearlerPlatform.Domain.UserInfo;
using DearlerPlatform.Service.CustomerApp.DTO;

namespace DearlerPlatform.Service.CustomerApp
{
    public interface ICustomerService : IocTag
    {
        Task<Customer> GetCustomerAsync(string cutomerNo);
        Task<bool> CheckPassword(CustomerLoginDto dto);
    }
}