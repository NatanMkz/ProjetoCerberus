namespace ProjetoCerberus.Domain.Exception;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DomainException : System.Exception
    {
        public DomainException(string message) : base(message) { }
    }