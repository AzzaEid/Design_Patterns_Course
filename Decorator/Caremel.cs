using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Caremel : BeverageDecorator
    {
        private readonly static int CaremelAddonPrice = 60;
        Beverage beverage;

        public Caremel(Beverage beverage)
        {
            this.beverage = beverage;
        }
    
        public override double getPrice()
        {
            return this.beverage.getPrice() + CaremelAddonPrice;
        }

        public override string getDescription()
        {
            return this.beverage.getDescription() + "\n" + $"extra Caremel - {this.getPrice()}";


        }
    }
}
