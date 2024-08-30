using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertMate
{
    public class Unit
    {
        public string longName { get; set; }
        public string shortName { get; set; }
        public Unit(string longName, string shortName) {
            this.longName = longName;
            this.shortName = shortName;
        }

        public override string ToString()
        {
            return longName + " " + shortName + "";
        }
    }
}
