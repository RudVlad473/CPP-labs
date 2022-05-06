public class Product
{
    protected string _name;
    protected decimal _price;

    public Product()
    {
        _name = "None";
        _price = decimal.Zero;
    }
    public Product(string _name, decimal _price)
    {
        this._name = _name;
        this._price = _price;
    }

    public override string ToString() => $"{_name} {_price}";
    
}

public class Food : Product
{
    private double _calories;
    public Food():base()
    {
        _calories = 0.0;
    }
    public Food(in string _name, in decimal _price, 
        in double _calories) : 
        base(_name, _price)
    {
        this._calories = _calories;
    }

    public override string ToString() => base.ToString() + $" {_calories}";

}

public class Drink : Product
{
    private string _flavor;
    public Drink():base()
    {
        _flavor = "None";
    }
    public Drink(in string _name, in decimal _price,
        in string _flavor) : base(_name, _price)
    {
        this._flavor = _flavor;
    }

    public override string ToString() => base.ToString() + $" {_flavor}";
}

public class Clothes : Product
{
    private string _clothesType;
    public Clothes():base()
    {
        _clothesType = "None";
    }
    public Clothes(in string _name, in decimal _price, in string _clothesType) :
        base(_name, _price)
    {
        this._clothesType = _clothesType;
    }

    public override string ToString() => base.ToString() + $" {_clothesType}";
    
}
class Program
{
    static void Main()
    {
        Product someProduct = new Product();
        Product myProduct1 = new Product("Pencil", (decimal)1.5);

        Food someFood = new Food();
        Food myFood1 = new Food("Bread", 1, 100.34);

        Drink someDrink = new Drink();
        Drink myDrink1 = new Drink("Coca-Cola", (decimal)0.9, "Orange");

        Clothes someClothes = new Clothes();
        Clothes myClothes1 = new Clothes("Gucci", (decimal)55.5, "Glasses");

        Console.WriteLine(someProduct.ToString());
        Console.WriteLine(someFood.ToString());
        Console.WriteLine(someDrink.ToString());
        Console.WriteLine(someClothes.ToString());

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine(myProduct1.ToString());
        Console.WriteLine(myFood1.ToString());
        Console.WriteLine(myDrink1.ToString());
        Console.WriteLine(myClothes1.ToString());
    }
}
