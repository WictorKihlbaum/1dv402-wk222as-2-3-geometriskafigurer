using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometriskaFigurer.cs
{
    public class Rectangle : Shape
    {
        
        // Beräknar och returnerar arean för 'Rectangle'.
        public abstract double Area
        {
            get
            {
                return Length * Width;
            }
        }

        // Beräknar och returnerar omkretsen för 'Rectangle'.
        public abstract double Perimeter
        {
            get
            {
                return 2 * Length + 2 * Width;
            }
        }

        // Konstruktorn anropar baskonstruktorn och ser till att längd och bredd sätts till det nya objektet.
        public Rectangle(double length, double width) : base(length, width) {}
    }
}
