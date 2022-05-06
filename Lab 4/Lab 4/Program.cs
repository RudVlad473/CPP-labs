
class ProductException: Exception
{
    public ProductException(in string message) : base(message)
    {
        Console.WriteLine(message);
    }
}

class Program
{
    static void Main()
    {
        Product product = new Product();
        try
        {
            product = new Product("Leather", 100000000);
        }
        catch(ProductException ex)
        {
            product._name = "Leather";
            product._price = 100;
        }

        Food food = new Food();
        try
        {
            food = new Food("BreadBreadBreadBreadBreadBreadBreadBreadBread", 10, 123.22);
        }
        catch (ProductException ex)
        {
            food._name = "Bread";
            food._price = 123.11m;
        }
        
        
        Drink   drink   = new Drink  ("Pepsi"  , 15 , "Lemon");
        Clothes clothes = new Clothes("Jacket" , 250, "Upper");

        Container myCont = new Container();

        
        myCont.PushBack(drink);
        myCont.PushBack(clothes);

        Console.WriteLine(myCont.ToString());
        Console.WriteLine();
        /*----------------------------------------------------*/

        




    }
}
