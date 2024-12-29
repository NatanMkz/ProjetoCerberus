namespace ProjetoCerberus.Domain.Exception;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InvalidSeverityException : DomainException
    {
        public InvalidSeverityException() : base("The severity level is invalid.") { }
    }