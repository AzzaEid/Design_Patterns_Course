namespace Factory.SimpleFactory
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Pizza
    {
        private string _name;
        private string _dough;
        private string _sauce;
        private List<string> toppings = new List<string>();

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public List<string> Toppings
        {
            get { return toppings; }
        }

        #region CONSTRUCTORS

        public Pizza(string name, string dough, string sauce)
        {
            _name = name;
            _dough = dough;
            _sauce = sauce;
        }

        #endregion

        public void Prepare()
        {
            Console.WriteLine("Preparing " + _name);
        }

        public void Bake()
        {
            Console.WriteLine("Baking " + _name);
        }

        public void Cut()
        {
            Console.WriteLine("Cutting " + _name);
        }

        public void Box()
        {
            Console.WriteLine("Boxing " + _name);
        }

        // code to display pizza name and ingredients
        public override string ToString()
        {
            StringBuilder display = new StringBuilder();
            display.Append("---- " + _name + " ----\n");
            display.Append(_dough + "\n");
            display.Append(_sauce + "\n");
            foreach (string topping in toppings)
            {
                display.Append(topping + "\n");
            }

            return display.ToString();
        }
    }
}