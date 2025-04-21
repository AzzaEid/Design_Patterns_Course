namespace Factory.MethodFactory
{
    using System;

    public class DependentPizzaStore
    {
        public Pizza CreatePizza(string style, string type)
        {
            Pizza pizza = null;

            if (style == "NY")
            {
                switch (type)
                {
                    case "cheese":
                        pizza = new NYStyleCheesePizza();
                        break;
                    case "veggie":
                        pizza = new NYStyleVeggiePizza();
                        break;
                    case "clam":
                        pizza = new NYStyleClamPizza();
                        break;
                    case "pepperoni":
                        pizza = new NYStylePepperoniPizza();
                        break;
                }
            }
            else if (style == "Chicago")
            {
                switch (type)
                {
                    case "cheese":
                        pizza = new ChicagoStyleCheesePizza();
                        break;
                    case "veggie":
                        pizza = new ChicagoStyleVeggiePizza();
                        break;
                    case "clam":
                        pizza = new ChicagoStyleClamPizza();
                        break;
                    case "pepperoni":
                        pizza = new ChicagoStylePepperoniPizza();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error: invalid store");
                return null;
            }
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}