using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RainExtention.Domain.Interface;
using RainExtention.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Repositories
{
    public class EnableProceduresRepository : IEnableProceduresRepository
    {

        private readonly ApplicationDbContext _context;

        public EnableProceduresRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> RunEnableProcedures()
        {
            var sql = "EXEC [dbo].[-Usp_EnableProcedures] ";
            return await _context.Database.ExecuteSqlRawAsync(sql);
        }

    }
}
