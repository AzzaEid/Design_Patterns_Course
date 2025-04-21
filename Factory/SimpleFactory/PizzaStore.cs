using Factory.SimpleFactory;

namespace Factory.SimpleFactory
{
    public class PizzaStore
    {
        private SimplePizzaFactory _factory;

        #region CONSTRUCTORS

        public PizzaStore(SimplePizzaFactory factory)
        {
            _factory = factory;
        }

        #endregion

        public Pizza OrderPizza(string type)
        {
            Pizza pizza = _factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}