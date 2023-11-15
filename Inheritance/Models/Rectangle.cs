using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Rectangle : Shape2D
    {
        public Rectangle(int width, int height) : base("Prostokąt", width, height)
        {
        }

        public override float CalculateArea()
        {
            return Width * Height;
        }
    }
}
