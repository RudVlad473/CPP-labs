using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Clothes<T> : Product
{
    private T? _clothesType;
    public Clothes() : base()
    {        
        _clothesType = default(T);
    }
    public Clothes(in string _name, in decimal _price, in T _clothesType) :
        base(_name, _price)
    {
        this._clothesType = _clothesType;
    }

    public override string ToString() => base.ToString() + $" {_clothesType}";

}
