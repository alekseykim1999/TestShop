using Supermarket.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Supermarket.Item
{
    class Jeans : Clothe
    {
        private bool hygroscopicity;
        public Jeans(string _name, int _price, int _size, string _material, string company_name, bool _hydroscopity) : base(_name, _price, _size, _material)
        {
            this.hygroscopicity = _hydroscopity;
        }


    }

}
