using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Milk : BeverageDecorator
    {
        private readonly static int milkAddonPrice = 60;
        Beverage beverage;

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double getPrice()
        {
            return this.beverage.getPrice() + milkAddonPrice;
        }

        public override string getDescription()
        {
            return this.beverage.getDescription() + "\n" + $"extra milk - {getPrice()}";
        }
    }
}
