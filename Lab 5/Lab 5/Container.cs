using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Container
{
    private Product[] _objectArr;
    public int Size { get; private set; } = 0;


    public Container(in int _length = 0)
    {
        if (_length < 0)
            Size = 0;

        _objectArr = new Product[_length];
        Size = _length;
        for (int i = 0; i < _length; i++)
        {
            _objectArr[i] = new Product();
        }
    }

    public void PushBack(in Product _value)
    {
        Product[] _newObjectArr = new Product[Size + 1];
        for (int i = 0; i < Size; i++)
        {
            _newObjectArr[i] = _objectArr[i];
        }

        _newObjectArr[Size] = _value;
        Size++;
        _objectArr = _newObjectArr;


    }

    public bool Erase(in int _index)
    {
        if (_index < 0 || _index >= _objectArr.Length)
            return false;

        Size--;
        Product[] _newObjectArr = new Product[Size];

        for (int i = 0; i < _index; i++)
        {
            _newObjectArr[i] = _objectArr[i];
        }
        for (int i = _index; i < Size; i++)
        {
            _newObjectArr[i] = _objectArr[i + 1];
        }

        _objectArr = _newObjectArr;

        return true;
    }

    public void Sort()
    {
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size - 1; j++)
            {
                if (_objectArr[j]._price > _objectArr[j + 1]._price)
                {

                    var temp = _objectArr[j + 1];
                    _objectArr[j + 1] = _objectArr[j];
                    _objectArr[j] = temp;
                }
            }
        }
    }

    public override string ToString()
    {
        string arrString = new string("");

        for (int i = 0; i < Size; i++)
        {
            arrString += _objectArr[i].ToString() + "\n";
        }

        return arrString;
    }

    public Product? this[in int i]
    {
        get
        {
            if (i < 0 || i >= Size)
                return null;

            return _objectArr[i];
        }
        set
        {
            _objectArr[i] = value;
        }
    }

    public Product? this[in string name]
    {
        get
        {
            for (int i = 0; i < Size; i++) 
            {
                if(this[i].Name == name)                
                    return this[i];                
            }

            return null;
        }
        set
        {
            for (int i = 0; i < Size; i++)
            {
                if (this[i].Name == name)                
                    this[i] = value;                
            }
        }
    }

    public Product? this[in decimal price]
    {
        get
        {
            for (int i = 0; i < Size; i++)
            {
                if (this[i]._price == price)
                    return this[i];
            }

            return null;
        }
        set
        {
            for (int i = 0; i < Size; i++)
            {
                if (this[i]._price == price)
                    this[i] = value;
            }
        }
    }
}

