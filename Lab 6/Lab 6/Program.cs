class Program
{
    static void Main()
    {
        //Clothes my = new Clothes();
        Product       product = new Product      ("Coca-Cola", 123.33M);
        Food<double>  food    = new Food<double> ("Bread", 12, 13.3);
        Drink<string> drink   = new Drink<string>("Fanta", 123, "Orange");
        Clothes<int>  clothes = new Clothes<int> ("Jacket", 111, 1);
        





    }
}
