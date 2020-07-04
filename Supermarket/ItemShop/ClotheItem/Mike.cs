using Supermarket.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Supermarket.Item
{
    class Mike : Clothe
    {
        private int color_code;

        public Mike(string _name, int _price, int _size, string _material, string company_name, int _color_code) : base(_name, _price, _size, _material)
        {
            this.color_code = _color_code;
        }



    }
}

