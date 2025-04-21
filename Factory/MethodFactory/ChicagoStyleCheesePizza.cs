namespace Factory.MethodFactory
{
    using System;

    public class ChicagoStyleCheesePizza : Pizza
    {
        #region CONSTRUCTORS

        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzarella Cheese");
        }

        #endregion

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}