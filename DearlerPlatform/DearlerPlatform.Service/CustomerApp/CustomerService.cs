using DearlerPlatform.Core.Repository;
using DearlerPlatform.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearlerPlatform.Service.CustomerApp.DTO
{
    public partial class CustomerService: ICustomerService
    {
        public CustomerService(IRepository<Customer> customerRepo, IRepository<CustomerInvoice> customerInvoiceRepo, IRepository<CustomerPwd> customerPwdRepo)
        {
            CustomerRepo = customerRepo;
            CustomerInvoiceRepo = customerInvoiceRepo;
            CustomerPwdRepo = customerPwdRepo;
        }

        public IRepository<Customer> CustomerRepo { get; }
        public IRepository<CustomerInvoice> CustomerInvoiceRepo { get; }
        public IRepository<CustomerPwd> CustomerPwdRepo { get; }

        /// <summary>
        /// 根据cutomerNo返回用户所有信息
        /// </summary>
        /// <param name="cutomerNo"></param>
        /// <returns></returns>
        public async Task<Customer> GetCustomerAsync(string cutomerNo)
        {
            return await CustomerRepo.GetAsync(m => m.CustomerNo == cutomerNo);
        }
    }
}
