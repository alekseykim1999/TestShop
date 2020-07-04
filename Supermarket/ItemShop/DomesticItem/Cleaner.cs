using Supermarket.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Item
{
    class Cleaner : Domestic
    {
        private string appointment;
        public Cleaner(string _name, int _price, double _chemical, string _appointment) : base(_name, _price, _chemical)
        {
            this.appointment = _appointment;
        }

    }
}

