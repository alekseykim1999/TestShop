using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Item
{
    abstract class Item
    {
        public int price;
        public string name;
    
        public Item(string _name, int _price)
        {
            this.name = _name;
            this.price = _price;
        }

        public Item()
        {

        }
        public void getInformation()
        {
            StringBuilder informator = new StringBuilder("Товар: ");
            informator.Append(name);
            informator.Append("| Цена: ");
            informator.Append(price);
            Console.WriteLine(informator);
        }
    }
}
