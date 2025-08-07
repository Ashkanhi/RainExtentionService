using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RainExtention.Domain.Entities;


namespace RainExtention.Domain
{
    public interface IStockDocumentRepository
    {
        Task<List<StockDocument>> GetAllAsync();
        Task<StockDocument?> GetByIdAsync(Guid documentId);
        Task AddAsync(StockDocument document);
        Task SaveAsync();
    }
}
