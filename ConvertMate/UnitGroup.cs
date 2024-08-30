using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertMate
{
    public  class UnitGroup
    {
        public List<Unit> unitsList { get; set; }
        public UnitGroup(List<Unit> unitsList)
        {
            this.unitsList = unitsList;
        }
    }
}
