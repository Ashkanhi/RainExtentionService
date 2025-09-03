using RainExtention.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainExtention.Domain.Interface
{
    public interface ISaleInvoiceRepository
    {
        Task<SaleInvoiceDto?> GetByIdAsync(Guid invoiceId);
        Task<string?> GetLastInvoiceNumberAsync(int bookerStoreId);
        Task AddAsync(SaleInvoiceDto invoice);
    }
}
