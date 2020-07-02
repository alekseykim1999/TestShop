using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.Buyers;
using Supermarket.Interfaces;

namespace Supermarket.Buyers
{
    class LazyBuyer : Buyer
    {
        public LazyBuyer(int _id) : base(_id)
        {

        }
    }
}
