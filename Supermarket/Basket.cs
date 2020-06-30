using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.Item;
namespace Supermarket.Item
{
    class Basket
    {
        List<Item> list_of_items = new List<Item>();


        public void addItem(Item item)
        {
            list_of_items.Add(item);
        }

        public List<Item> getItems()
        {
            return list_of_items;
        }
    }
}
