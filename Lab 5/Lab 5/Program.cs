


class Program
{
    static void Main()
    {
        /*----------------------------------------------------*/
        Product product = new Product("Leather", 25);
        Food    food    = new Food   ("Bread"  , 10 , 123.22);
        Drink   drink   = new Drink  ("Pepsi"  , 15 , "Lemon");
        Clothes clothes = new Clothes("Jacket" , 250, "Upper");

        Container myCont = new Container();

        myCont.PushBack(product);
        myCont.PushBack(food);
        myCont.PushBack(drink);
        myCont.PushBack(clothes);

        Console.WriteLine(myCont.ToString());
        Console.WriteLine();
        /*----------------------------------------------------*/

        //Индекс по номеру
        for(int i = 0; i < myCont.Size; i++)
        {
            Console.WriteLine($"Array[{i}] =  " + myCont[i]);
        }
        Console.WriteLine();

        //Индекс по имени товара
        Console.WriteLine($"Array[\"Bread\"]  = " + myCont["Bread"]);
        Console.WriteLine($"Array[\"Jacket\"] = " + myCont["Jacket"]);
        Console.WriteLine();

        ////
        ///
        IName InameProd1 = product;
        IName InameProd2 = food;
        IName InameProd3 = drink;
        IName InameProd4 = clothes;

        

        Console.WriteLine(InameProd1.Name);
        Console.WriteLine(InameProd2.Name);
        Console.WriteLine(InameProd3.Name);
        Console.WriteLine(InameProd4.Name);





    }
}
