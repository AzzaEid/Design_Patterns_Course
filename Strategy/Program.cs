namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck model = new ModelDuck();

            Console.WriteLine("Default behavior:");
            model.performFly();
            model.performQuack();

            Console.WriteLine("\nChoose Fly Behavior:");
            Console.WriteLine("1. Fly with wings");
            Console.WriteLine("2. Can't fly");
            Console.WriteLine("3. Fly with rocket");
            int flyChoice = int.Parse(Console.ReadLine());

            switch (flyChoice)
            {
                case 1:
                    model.setFlyBehavior(new FlyWithWings());
                    break;
                case 2:
                    model.setFlyBehavior(new FlyNoWay());
                    break;
                case 3:
                    model.setFlyBehavior(new FlyRocketPowered());
                    break;
                default:
                    Console.WriteLine("Invalid fly choice");
                    break;
            }

            Console.WriteLine("\nChoose Quack Behavior:");
            Console.WriteLine("1. Quack");
            Console.WriteLine("2. Mute");
            Console.WriteLine("3. Squeak");
            int quackChoice = int.Parse(Console.ReadLine());

            switch (quackChoice)
            {
                case 1:
                    model.setQuackBehavior(new Quack());
                    break;
                case 2:
                    model.setQuackBehavior(new MuteQuack());
                    break;
                case 3:
                    model.setQuackBehavior(new Squeak());
                    break;
                default:
                    Console.WriteLine("Invalid quack choice");
                    break;
            }

            Console.WriteLine("\nUpdated behavior:");
            model.performFly();
            model.performQuack();
        }
    }
}
