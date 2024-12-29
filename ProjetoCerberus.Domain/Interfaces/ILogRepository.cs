using ProjetoCerberus.Domain.Entities;
using System;


namespace ProjetoCerberus.Domain.Interfaces
{
    public interface ILogRepository
{
    Task SaveLogAsync(Log log);
    Task<IEnumerable<Log>> GetLogsAsync();
}

}
