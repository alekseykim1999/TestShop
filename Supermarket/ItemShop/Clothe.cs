using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Item
{
    class Clothe : Item
    {
        public int size;
        public string material_code;
        public Clothe(string _name, int _price, int _size, string _material) : base(_name,_price)
        {
            this.size = _size;
            this.material_code = _material;
        }
    }
}
