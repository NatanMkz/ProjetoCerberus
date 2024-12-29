namespace ProjetoCerberus.Domain.ValueObjects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Severity
    {
        public string Level { get; private set; }

        private Severity(string level)
        {
            Level = level;
        }

        public static Severity Low => new Severity("Low");
        public static Severity Medium => new Severity("Medium");
        public static Severity High => new Severity("High");

        public override string ToString()
        {
            return Level;
        }
    }