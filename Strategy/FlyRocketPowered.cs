using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class FlyRocketPowered : FlyBehavior
    {
    public void fly()
    {
            Console.WriteLine("I'm flying with a rocket!");
    }
}

}
