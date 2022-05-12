using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Food<T> : Product where T: struct
{
    private T _calories;
    public Food() : base()
    {
        _calories = default(T);
    }
    public Food(in string _name, in decimal _price,
        in T _calories) :
        base(_name, _price)
    {
        this._calories = _calories;
    }

    public override string ToString() => base.ToString() + $" {_calories}";

}
