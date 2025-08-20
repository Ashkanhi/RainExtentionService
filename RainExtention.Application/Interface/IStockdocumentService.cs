using RainExtention.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainExtention.Application.Interface
{
    public interface IStockDocumentService
    {

        Task<StockDocument?> GetByIdAsync(Guid documentId);
        Task<StockDocument> AddAsync(StockDocument document);
        //Task AddStockDocumentAsync(StockDocument document);
        //Task<List<StockDocument>> GetAllStockDocumentsAsync();
        //Task<StockDocument?> GetStockDocumentByIdAsync(Guid id);
    }
}
