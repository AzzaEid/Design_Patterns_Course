namespace Factory.AbstractFactory.Pizzas
{
    using Factory.AbstractFactory.Factories;
    using System;

    public class PepperoniPizza : Pizza
    {
        private IPizzaIngredientFactory _ingredientFactory;

        #region CONSTRUCTORS

        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        #endregion

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            dough = _ingredientFactory.CreateDough();
            sauce = _ingredientFactory.CreateSauce();
            cheese = _ingredientFactory.CreateCheese();
            veggies = _ingredientFactory.CreateVeggies();
            pepperoni = _ingredientFactory.CreatePepperoni();
        }
    }
}