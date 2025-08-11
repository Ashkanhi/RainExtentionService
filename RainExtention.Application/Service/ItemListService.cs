using RainExtention.Application.Interface;
using RainExtention.Domain.Entities;
using RainExtention.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainExtention.Application.Service
{
    public class ItemListService : IItemListService
    {
        private readonly IItemListRepository _repository;

        public ItemListService(IItemListRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ItemListDto>> GetItemListAsync()
        {
            return await _repository.GetItemListAsync();
        }
    }
}
