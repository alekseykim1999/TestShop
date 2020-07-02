using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.Item;
namespace Supermarket.Item
{
    class Food : Item, IExpirable
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

        public int getExpiredDate()
        {
          
            TimeSpan remainingDays = DateTime.Today.Subtract(release_date.AddDays(shelf_days));
            return remainingDays.Days;
        }

    }
}

