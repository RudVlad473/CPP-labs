using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Product : IName<string>
{
    public string Name { get; set; }
    public decimal _price { get; }

    public Product()
    {
        Name = "None";
        _price = decimal.Zero;
    }
    public Product(string _name, decimal _price)
    {
        this.Name = _name;
        this._price = _price;
    }

    public override string ToString() => $"{Name} {_price}";    

    public int CompareTo(IName<string>? other)
    {
        return Name.CompareTo(other?.Name);
    }

    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }
}
