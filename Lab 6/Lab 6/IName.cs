using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 public interface IName<T> : IComparable where T: IComparable
 {
    T Name { get; }

    //int CompareTo(in T? value)
    //{
    //    return Name.CompareTo(value);
    //}

    

}

