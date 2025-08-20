using RainExtention.Application.Interface;
using RainExtention.Domain.Entities;
using RainExtention.Domain.Interface;

namespace RainExtention.Application.Service
{
    public class StockDocumentService : IStockDocumentService
    {
        private readonly IStockDocumentRepository _repository;
        public async Task<StockDocument> AddAsync(StockDocument document)
        {
            // ایجاد Guid جدید اگر DocumentId خالی بود
            if (document.DocumentId == Guid.Empty)
                document.DocumentId = Guid.NewGuid();

            document.CreationDate = DateTime.UtcNow;

            await _repository.AddAsync(document);
            return document;
        }
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
