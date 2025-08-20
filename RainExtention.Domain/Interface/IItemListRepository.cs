using RainExtention.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainExtention.Domain.Interface
{
      public  interface IItemListRepository
    {
        Task<IEnumerable<ItemListDto>> GetItemListAsync();
        Task<IEnumerable<ItemListDto>> GetItemsByIdsAsync(List<Guid> itemIds); 
    }
}
