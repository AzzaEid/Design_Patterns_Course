using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CoffeeShop
    {
        static void Main(string[] args)
        {
            /*
            Beverage amricano = new Americano();
            amricano = new Milk(amricano);
            amricano = new Milk(amricano);
            amricano = new Milk(amricano);
            amricano = new Milk(amricano);
            amricano = new Caremel(amricano);


            Console.WriteLine(amricano.getDescription());
            Console.WriteLine($"Total price: {amricano.getPrice()}");

            Beverage dalgona = new Dalgona();
            dalgona = new Milk(dalgona);
            dalgona = new Caremel(dalgona);
            dalgona = new ChoclateSyrup(dalgona);

            Console.WriteLine( dalgona.getDescription());
            Console.WriteLine($"Price: {dalgona.getPrice()}");
            */
            Console.WriteLine("Welcome to the Coffee Shop!");
            Console.WriteLine("Choose your base coffee:");
            Console.WriteLine("1. Americano");
            Console.WriteLine("2. Dalgona");
            Console.WriteLine("3. Espresso");


            string baseChoice = Console.ReadLine();
            Beverage myCoffee;

            switch (baseChoice)
            {
                case "1":
                    myCoffee = new Americano();
                    break;
                case "2":
                    myCoffee = new Dalgona();
                    break;
                case "3":
                    myCoffee = new Espresso();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Defaulting to Americano.");
                    myCoffee = new Americano();
                    break;
            }

            while (true)
            {
                Console.WriteLine("Add-ons:");
                Console.WriteLine("1. Milk");
                Console.WriteLine("2. Caramel");
                Console.WriteLine("3. Chocolate Syrup");
                Console.WriteLine("4. Finish order");

                string addOnChoice = Console.ReadLine();
                if (addOnChoice == "4") break;

                switch (addOnChoice)
                {
                    case "1":
                        myCoffee = new Milk(myCoffee);
                        Console.WriteLine("Milk added");
                        break;
                    case "2":
                        myCoffee = new Caremel(myCoffee);
                        Console.WriteLine("Caramel added");
                        break;
                    case "3":
                        myCoffee = new ChoclateSyrup(myCoffee);
                        Console.WriteLine("Chocolate Syrup added");
                        break;
                    default:
                        Console.WriteLine("Invalid add-on choice.");
                        break;
                }
            }
            Console.WriteLine("\nYour Order Summary:");
            Console.WriteLine( myCoffee.getDescription());
            Console.WriteLine("-------------------");
            Console.WriteLine("Total Price: " + myCoffee.getPrice() + "");
        }
    }
        }
    
    


