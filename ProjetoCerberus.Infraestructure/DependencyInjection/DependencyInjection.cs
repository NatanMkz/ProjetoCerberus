using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using ProjetoCerberus.Domain.Interfaces;
using ProjetoCerberus.Infrastructure.Persistence.DbContext;
using ProjetoCerberus.Infrastructure.Persistence.Repositories;
using ProjetoCerberus.Infrastructure.Messaging.RabbitMQ;

namespace ProjetoCerberus.Infrastructure.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Configuração do banco de dados
            services.AddDbContext<CerberusDbContext>(options =>
                options.UseMySql(configuration.GetConnectionString("DefaultConnection"),
                                 ServerVersion.AutoDetect(configuration.GetConnectionString("DefaultConnection"))));

            // Registro de repositórios
            services.AddScoped<ILogRepository, LogRepository>();

            return services;
        }
    }
}
