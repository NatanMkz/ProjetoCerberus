using Microsoft.EntityFrameworkCore;
using ProjetoCerberus.Domain.Entities;
using ProjetoCerberus.Domain.Interfaces;
using ProjetoCerberus.Infrastructure.Persistence.DbContext;


namespace ProjetoCerberus.Infrastructure.Persistence.Repositories
{
    public class LogRepository : ILogRepository
    {
        private readonly CerberusDbContext _context;

        public LogRepository(CerberusDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task SaveLogAsync(Log log)
        {
            if (log == null) throw new ArgumentNullException(nameof(log));

            await _context.Logs.AddAsync(log);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Log>> GetLogsAsync()
        {
            return await _context.Logs.ToListAsync();
        }
    }
}
