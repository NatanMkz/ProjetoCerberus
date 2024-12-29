namespace ProjetoCerberus.Domain.ValueObjects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LogSource
    {
        public string Name { get; private set; }

        public LogSource(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Log source cannot be empty.");

            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }