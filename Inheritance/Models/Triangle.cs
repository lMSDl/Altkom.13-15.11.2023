using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Triangle : Shape2D
    {
        public float Angle { get; set; }

        public Triangle(int width, int height, float angle) : base("Trójkąt", width, height)
        {
            Angle = angle;
        }

        public override string ToString()
        {
            return $"{base.ToString()} oraz kącie między bokami {Angle}";
        }

        public override float CalculateArea()
        {
            return(float)(Width * Height * Math.Cos(Angle));
        }
    }
}
