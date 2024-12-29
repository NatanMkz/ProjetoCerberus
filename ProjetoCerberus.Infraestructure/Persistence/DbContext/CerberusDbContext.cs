using Microsoft.EntityFrameworkCore;
using ProjetoCerberus.Domain.Entities;

namespace ProjetoCerberus.Infrastructure.Persistence.DbContext
{
    public class CerberusDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Log> Logs { get; set; }
        public DbSet<Vulnerability> Vulnerabilities { get; set; }

        public CerberusDbContext(DbContextOptions<CerberusDbContext> options) : base(options) { }
    }
}