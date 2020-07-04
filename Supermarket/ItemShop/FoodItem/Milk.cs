using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.Item;
namespace Supermarket.Item
{
    class Milk : Food
    {
        public int fat;

        public Milk(string _name, int _price, DateTime _release, int _shelf, int _fat) : base(_name, _price, _release, _shelf)
        {
            this.fat = _fat;
        }

    }
}

