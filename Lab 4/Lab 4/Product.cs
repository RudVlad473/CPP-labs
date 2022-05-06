using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Product
{
    public string _name { get; set; }
    public decimal _price { get; set; }

    public Product()
    {
        _name = "None";
        _price = decimal.Zero;
    }
    public Product(string _name, decimal _price)
    {
        if (_price >= 100000000)
        {
            throw new ProductException("TOO EXPENSIVE!");
        }
        else if(_name.Length >= 15)
        {
            throw new ProductException("You cannot set such a long name");
        }
        this._name = _name;
        
        this._price = _price;
    }

    public override string ToString() => $"{_name} {_price}";

}
