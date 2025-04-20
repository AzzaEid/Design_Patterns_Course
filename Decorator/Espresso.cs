using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Espresso : Beverage
        {

        public Espresso()
        {
            this.description = $"Espresso - {this.getPrice()}";
        }

        
        public override double getPrice()
        {
            return 100.00;
        }

        
        public override string getDescription()
        {
            return this.description;
        }
    }
}
