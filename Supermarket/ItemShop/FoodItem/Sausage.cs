using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Supermarket.Item
{ 
    class Sausage : Food
    {

        public String meat_sort { get; set; }
        public String company { get; set; }
        public double fat_сontent { get; set; }
        public bool is_dietary { get; set; }

        public Sausage(string _name, int _price, DateTime _release, int _shelf) : base(_name, _price, _release, _shelf)
        {

        }

        public Sausage()
        {

        }
    }
    class SausageBuilder
    {
        private Sausage sausage;

        public SausageBuilder()
        {
            sausage = new Sausage();
        }
        public SausageBuilder setName(string _name)
        {
            sausage.name = _name;
            return this;
        }
        public SausageBuilder setPrice(int _price)
        {
            sausage.price = _price;
            return this;
        }
        public SausageBuilder setMeatSort(string _meat)
        {
            sausage.meat_sort = _meat;
            return this;
        }
        public SausageBuilder setCompany(string _company)
        {
            sausage.company = _company;
            return this;
        }
        public SausageBuilder setShelfDays(int _days)
        {
            if(_days>10)
                sausage.shelf_days = _days;
            return this;
        }
        public SausageBuilder setFatContent(double _fat)
        {
            sausage.fat_сontent = _fat;
            return this;
        }
        public SausageBuilder setIsDietary(bool _dietary)
        {
            sausage.is_dietary = _dietary;
            return this;
        }


        
        public static implicit operator Sausage(SausageBuilder builder)
        {
            return builder.sausage;
        }


    }
  
}
