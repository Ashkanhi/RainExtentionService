using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RainExtention.Domain.Interface;
using RainExtention.Domain.Entities;


namespace RainExtention.Application.Service
{
    public class SaleInvoiceService
    {
        private readonly ISaleInvoiceRepository _repository;

        public SaleInvoiceService(ISaleInvoiceRepository repository)
        {
            _repository = repository;
        }

        public async Task<SaleInvoice?> GetInvoiceByIdAsync(Guid invoiceId)
        {
            return await _repository.GetByIdAsync(invoiceId);
        }


        public async Task AddAsync(SaleInvoice invoice)
        {
            await _repository.AddAsync(invoice);
        }
    }
}
