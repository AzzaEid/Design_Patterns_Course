namespace Factory.MethodFactory
{
    using System;

    public class ChicagoStylePepperoniPizza : Pizza
    {
        #region CONSTRUCTORS

        public ChicagoStylePepperoniPizza()
        {
            Name = "Chicago Style Pepperoni Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzarella Cheese");
            Toppings.Add("Black Olives");
            Toppings.Add("Spinach");
            Toppings.Add("Eggplant");
            Toppings.Add("Sliced Pepperoni");
        }

        #endregion

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}