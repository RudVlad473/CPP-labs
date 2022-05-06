using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Drink : Product
{
    private string _flavor;
    public Drink() : base()
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
