/*
namespace Factory.SimpleFactory
{
    using System;

    class PizzaTestDrive
    {
        static void Main(string[] args)
        {
            var factory = new SimplePizzaFactory();
            var store = new PizzaStore(factory);

            var pizza = store.OrderPizza("cheese");
            Console.WriteLine("We ordered a " + pizza.Name + "\n");

            pizza = store.OrderPizza("veggie");
            Console.WriteLine("We ordered a " + pizza.Name + "\n");

            // Wait for user
            Console.ReadKey();
        }
    }

    #region PizzaStore

    #endregion

    #region SimplePizzaFactory

    #endregion

    #region Pizza

    #endregion
}
/*/