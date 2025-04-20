using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Dalgona : Beverage
    {
        public Dalgona()
        {
            this.description = $"Dalgona - {this.getPrice()}";
        }

        public override string getDescription()
        {
            return this.description;
        }

        public override double getPrice()
        {
            return 300;
        }
}
}
