namespace ProjetoCerberus.Domain.Events;
using ProjetoCerberus.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LogCreatedEvent
    {
        public Log Log { get; private set; }

        public LogCreatedEvent(Log log)
        {
            Log = log;
        }
    }