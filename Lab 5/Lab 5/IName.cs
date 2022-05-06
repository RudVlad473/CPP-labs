using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 public interface IName : IComparable<IName>
 {
    string Name { get; set; }
 }

