using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.Item;
namespace Supermarket.Item
{
    class Food : Item
    {
        public DateTime release_date;
        public int shelf_days;

        public Food(string _name, int _price, DateTime _releaseDate, int _shelfLife) : base(_name, _price)
        {
            this.release_date = _releaseDate;
            this.shelf_days = _shelfLife;
        }

        public Food() : base()
        {

        }

    }
}

