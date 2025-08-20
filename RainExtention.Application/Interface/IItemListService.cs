using RainExtention.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainExtention.Application.Interface
{
    public interface IItemListService
    {
     
        Task<IEnumerable<ItemListDto>> GetItemListAsync();
        Task<IEnumerable<ItemListDto>> GetItemsByIdsAsync(List<Guid> itemIds);

    }
}
