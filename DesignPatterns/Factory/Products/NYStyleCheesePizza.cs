namespace Factory.Products
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "NY style sauce and cheese pizza";
            Dough = "Thin crust dough";
            Sauce = "Marinara sauce";
            Toppings.Add("Grated reggiano cheese");
        }
    }
}
