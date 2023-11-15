using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    //: - dziedziczenie
    public abstract class Shape1D : Shape
    {
        //właściwość read-only - brak settera
        public int Width { get; }

        //base - wywołanie konstruktora klasy bazowej
        public Shape1D(string name, int width) : base(name)
        {
            Width = width;
        }

        //base - odwołanie się do implementracji z klasy bazowej
        public override string ToString()
        {
            return $"{base.ToString()} o długości {Width}";
        }
    }
}
