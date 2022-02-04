using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnit
    {
        string Name { get; set; }
        double Health { get; set; }
        double MaxHealth { get; set; }
    }
}
