using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Supermarket.Item
{ 

    class Sausage : Food
    {
        public Sausage(string _name, int _price , DateTime _release, int _shelf) : base(_name, _price,_release, _shelf)
        {

        }

        public Sausage()
        {

        }
    }
}
