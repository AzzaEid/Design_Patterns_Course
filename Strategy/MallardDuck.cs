using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class MallardDuck : Duck
    {

        public MallardDuck()
        {
            // Defult values,
            // the challenge is to change it by user
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();

        }

        public override void display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
