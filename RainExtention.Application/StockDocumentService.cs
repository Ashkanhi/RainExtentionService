using RainExtention.Application.Interface;
using RainExtention.Domain;
using RainExtention.Domain.Entities;

namespace RainExtention.Application
{
    public class StockDocumentService : IStockDocumentService
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
