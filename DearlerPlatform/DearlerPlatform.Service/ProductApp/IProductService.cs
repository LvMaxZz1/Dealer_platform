using DearlerPlatform.Core;
using DearlerPlatform.Domain.UserInfo;
using DearlerPlatform.Service.ProductApp.DTO;

namespace DearlerPlatform.Service.ProductApp
{
    public interface IProductService : IocTag
    {
        Task<IEnumerable<ProductDto>> GetProductDto(PageWithSortDto pageWithSortDto);
    }
}
