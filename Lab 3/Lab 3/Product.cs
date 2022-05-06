using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Product
{
    public string _name { get; }
    public decimal _price { get; }

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
