namespace Factory.MethodFactory
{
    using System;

    public class ChicagoStyleVeggiePizza : Pizza
    {
        #region CONSTRUCTORS

        public ChicagoStyleVeggiePizza()
        {
            Name = "Chicago Deep Dish Veggie Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzarella Cheese");
            Toppings.Add("Black Olives");
            Toppings.Add("Spinach");
            Toppings.Add("Eggplant");
        }

        #endregion

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}