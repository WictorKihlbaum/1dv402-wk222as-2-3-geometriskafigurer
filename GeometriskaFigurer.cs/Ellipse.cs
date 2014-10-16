using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometriskaFigurer.cs
{
    public class Ellipse : Shape
    {
        
        // Beräknar och returnerar arean för 'Ellipse'.
        public override double Area
        {
            get
            {
                return Math.PI * (Length / 2) * (Width / 2);
            }
        }

        // Beräknar och returnerar omkretsen för 'Ellipse'.
        public override double Perimeter
        {
            get
            {
                return Math.PI * Math.Sqrt(2 * (Length / 2) * (Length / 2) + 2 * (Width / 2) * (Width / 2));
            }
        }
      
        // Konstruktorn anropar baskonstruktorn och ser till att längd och bredd sätts till det nya objektet.
        public Ellipse(double length, double width) : base(length, width) {}
    }
}
