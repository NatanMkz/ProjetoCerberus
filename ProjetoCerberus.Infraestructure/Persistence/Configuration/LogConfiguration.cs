using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoCerberus.Domain.Entities;

namespace ProjetoCerberus.Infrastructure.Persistence.Configurations
{
    public class LogConfiguration : IEntityTypeConfiguration<Log>
    {
        public void Configure(EntityTypeBuilder<Log> builder)
        {
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Source).IsRequired().HasMaxLength(100);
            builder.Property(l => l.Level).IsRequired().HasMaxLength(50);
            builder.Property(l => l.Message).IsRequired();
            builder.Property(l => l.Metadata).HasConversion(
                m => string.Join(";", m.Select(kv => $"{kv.Key}:{kv.Value}")),
                m => m.Split(';', StringSplitOptions.RemoveEmptyEntries)
                     .Select(s => s.Split(':'))
                     .ToDictionary(kv => kv[0], kv => kv[1]));
        }
    }
}