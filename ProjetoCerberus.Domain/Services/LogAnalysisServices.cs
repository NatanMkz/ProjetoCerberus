using ProjetoCerberus.Domain.Entities;

namespace ProjetoCerberus.Domain.Services
{
    public class LogAnalysisService
    {
        public bool DetectPattern(Log log)
        {
            return log.Message.Contains("Failed login attempt");
        }
    }
}
