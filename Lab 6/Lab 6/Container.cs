using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Container<T> where T: IComparable, IName<T>
{
    private T[] _objectArr;
   
    public int Size { get; private set; } = 0;


    public Container(in int _length = 0)
    {
        Size = _length;
        if (_length < 0)
            Size = 0;

        _objectArr = new T[_length];        
        for (int i = 0; i < _length; i++)
        {
            _objectArr[i] = default(T);
        }
    }

    public void PushBack(in T _value)
    {
        T[] _newObjectArr = new T[Size + 1];
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
        T[] _newObjectArr = new T[Size];

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
                if (_objectArr[j].CompareTo(_objectArr[j + 1]) == -1)
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
        StringBuilder str = new StringBuilder();

        for (int i = 0; i < Size; i++)
        {
            str.Append(_objectArr[i].ToString() + "\n");
        }

        return str.ToString();
    }

    public T? this[in int i]
    {
        get
        {
            if (i < 0 || i >= Size)
                return default(T);

            return _objectArr[i];
        }
        set
        {
            _objectArr[i] = value;
        }
    }

    public T? this[in T name]
    {
        get
        {
            if (this._objectArr != null)
            {
                for (int i = 0; i < Size; i++)
                {
                    if (this[i].Name.CompareTo(name) == 0)
                        return this[i];
                }
            }
            return default(T);
        }
        set
        {
            for (int i = 0; i < Size; i++)
            {
                if (this[i].Name.CompareTo(name) == 0)                
                    this[i] = value;                
            }
        }
    }

    //public Product? this[in decimal price]
    //{
    //    get
    //    {
    //        for (int i = 0; i < Size; i++)
    //        {
    //            if (this[i]._price == price)
    //                return this[i];
    //        }

    //        return null;
    //    }
    //    set
    //    {
    //        for (int i = 0; i < Size; i++)
    //        {
    //            if (this[i]._price == price)
    //                this[i] = value;
    //        }
    //    }
    //}
}

