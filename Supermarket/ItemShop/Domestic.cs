using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Item
{
    class Domestic : Item
    {
        public double chemical_value;
        public Domestic(string _name, int _price, double _chemical) : base(_name, _price)
        {
            this.chemical_value = _chemical;
        }
    }
}
