namespace Factory.AbstractFactory.Pizzas
{
    using Factory.AbstractFactory.Factories;
    using System;

    public class ClamPizza : Pizza
    {
        private IPizzaIngredientFactory _ingredientFactory;

        #region CONSTRUCTORS

        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
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
            clam = _ingredientFactory.CreateClam();
        }
    }
}