using RainExtention.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RainExtention.Domain.Entities;

namespace RainExtention.Application
{
    class StockDocumentService
    {
        private readonly IStockDocumentRepository _repository;

        public StockDocumentService(IStockDocumentRepository repository)
        {
            _repository = repository;
        }

        public async Task<StockDocument?> GetByIdAsync(Guid documentId)
        {
            return await _repository.GetByIdAsync(documentId);
        }
    }
}
