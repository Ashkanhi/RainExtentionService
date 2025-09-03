using RainExtention.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainExtention.Domain.Interface
{
    public  interface ICustomerRepository
    {
        Task<CustomerDto?> CheckCustomerByCode(string customerCode);
        Task<Guid> GetOrCreateCustomerForInvoiceAsync(string customerCode,
                                                         string? firstName,
                                                         string? lastName);
    }
}
