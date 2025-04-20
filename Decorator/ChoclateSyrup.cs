using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ChoclateSyrup : BeverageDecorator
    {

        private readonly static int ChoclateSyrupAddonPrice = 100;
        Beverage beverage;

        public ChoclateSyrup(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double getPrice()
        {
            return this.beverage.getPrice() + ChoclateSyrupAddonPrice;
        }

        public override String getDescription()
        {
            return this.beverage.getDescription() + "\n" + $"extra ChoclateSyrup  - {this.getPrice()}";
        }
    }
}
