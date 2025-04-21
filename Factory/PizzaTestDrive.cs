using System;
using Factory.AbstractFactory;
using Factory.MethodFactory;
using Factory.AbstractFactory.Stores;
using Factory.SimpleFactory;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("^ Welcome to the Pizza Store Demo! ^");
                Console.WriteLine("Select Factory Type:");
                Console.WriteLine("1. Simple Factory");
                Console.WriteLine("2. Factory Method");
                Console.WriteLine("3. Abstract Factory");
                Console.WriteLine("4. Exit");

                Console.Write("Your choice: ");
                var factoryChoice = Console.ReadLine();

                if (factoryChoice == "4") break;

                Console.Write("Enter pizza type (cheese, clam, pepperoni, veggie): ");
                var pizzaType = Console.ReadLine()?.ToLower();

                Console.WriteLine();

                switch (factoryChoice)
                {
                    case "1":
                        RunSimpleFactory(pizzaType);
                        break;
                    case "2":
                        RunFactoryMethod(pizzaType);
                        break;
                    case "3":
                        RunAbstractFactory(pizzaType);
                        break;
                    default:
                        Console.WriteLine("-- Invalid option. Try again.\n");
                        break;
                }

                Console.WriteLine("\n----------------------------\n");
            }

            Console.WriteLine(" Exiting... Thank you!");
        }

        static void RunSimpleFactory(string type)
        {
            var factory = new SimplePizzaFactory();
            var store = new SimpleFactory.PizzaStore(factory);

            var pizza = store.OrderPizza(type);
            if (pizza != null)
                Console.WriteLine($"=> You ordered a {pizza.Name} pizza via Simple Factory.");
        }

        static void RunFactoryMethod(string type)
        {
            Console.Write("Choose region (NY / Chicago): ");
            var region = Console.ReadLine()?.ToLower();

            MethodFactory.PizzaStore store = region switch
            {
                "ny" => new MethodFactory.NYPizzaStore(),
                "chicago" => new MethodFactory.ChicagoPizzaStore(),
                _ => null
            };

            if (store == null)
            {
                Console.WriteLine("-- Invalid region. Aborting...");
                return;
            }

            var pizza = store.OrderPizza(type);
            if (pizza != null)
                Console.WriteLine($"=> You ordered a {pizza.Name} pizza from {region.ToUpper()} style store.");
        }

        static void RunAbstractFactory(string type)
        {
            Console.Write("Choose region (NY / Chicago): ");
            var region = Console.ReadLine()?.ToLower();

            AbstractFactory.Stores.PizzaStore store = region switch
            {
                "ny" => new NewYorkPizzaStore(),
                "chicago" => new AbstractFactory.Stores.ChicagoPizzaStore(),
                _ => null
            };

            if (store == null)
            {
                Console.WriteLine("-- Invalid region. Aborting...");
                return;
            }

            var pizza = store.OrderPizza(type);
            if (pizza != null)
                Console.WriteLine($"=> You ordered a {pizza.Name} pizza using Abstract Factory from {region.ToUpper()}.");
        }
    }
}
