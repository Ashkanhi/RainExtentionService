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
using Microsoft.Data.SqlClient;
using System.Data;

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

        public async Task<IEnumerable<ItemListDto>> GetItemsByIdsAsync(List<Guid> itemIds)
        {
            if (itemIds == null || !itemIds.Any())
                return Enumerable.Empty<ItemListDto>();

            // ساخت جدول موقت برای ارسال به پروسیجر
            var dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(Guid));

            foreach (var id in itemIds)
            {
                dataTable.Rows.Add(id);
            }

            var parameter = new SqlParameter("@FilterItemID", SqlDbType.Structured)
            {
                TypeName = "dbo.GuidType",  // نام نوع TVP در دیتابیس
                Value = dataTable
            };

            return await _context.Set<ItemListDto>()
                .FromSqlRaw("EXEC Usp_GetItemsByIds @FilterItemID", parameter)
                .ToListAsync();

        }
    }
}
