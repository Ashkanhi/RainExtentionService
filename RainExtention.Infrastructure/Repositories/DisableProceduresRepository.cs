using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RainExtention.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using RainExtention.Domain.Interface;



namespace RainExtention.Infrastructure.Repositories
{
    public class DisableProceduresRepository : IDisableProceduresRepository
    {

        private readonly ApplicationDbContext _context;

        public DisableProceduresRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> RunDisableProcedures()
        {
            var sql = "EXEC Usp_DisableProcedures ";
            return await _context.Database.ExecuteSqlRawAsync(sql);
        }
    }
}
