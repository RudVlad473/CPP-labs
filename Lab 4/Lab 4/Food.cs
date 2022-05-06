using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Food : Product
{
    private double _calories;
    public Food() : base()
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
