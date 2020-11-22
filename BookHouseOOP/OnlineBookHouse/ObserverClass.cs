using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHouseOOP
{
    abstract class ObserverClass
    {
        public abstract void update(string communicationType, UserClass user, string product_name, double unitPriceValue);
    }
}
