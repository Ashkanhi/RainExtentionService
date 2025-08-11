using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RainExtention.Domain;
using RainExtention.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using static RainExtention.Infrastructure.Repositories.ItemListRepository;
using RainExtention.Infrastructure.Context;
using RainExtention.Domain.Interface;

namespace RainExtention.Infrastructure.Repositories
{
 
        public class ItemListRepository : IItemListRepository
        {
            private readonly ApplicationDbContext _context;

            public ItemListRepository(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<ItemListDto>> GetItemListAsync()
            {
            return await _context.Set<ItemListDto>()
             .FromSqlRaw("EXEC Usp_GetItemList")
             .ToListAsync();
        }
        }
}
