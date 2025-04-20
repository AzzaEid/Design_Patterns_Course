using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Americano : Beverage
    {
        public Americano()
        {
            this.description = $"Americano - {this.getPrice()}";
        }


        public override double getPrice()
        {
            return 200.00;
        }

        public override string getDescription()
        {
            return this.description;
        }
    }
}

