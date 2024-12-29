namespace ProjetoCerberus.Domain.Entities;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Log
{
    public Guid Id { get; set; }
    public DateTime Timestamp { get; set; }
    public string Source { get; set; }
    public string Level { get; set; }
    public string Message { get; set; }
    public Dictionary<string, string> Metadata { get; set; }

    // Construtor
    public Log(string source, string level, string message, Dictionary<string, string> metadata)
    {
        Source = source;
        Level = level;
        Message = message;
        Metadata = metadata;
    }
}
