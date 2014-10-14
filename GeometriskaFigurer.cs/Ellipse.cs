using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometriskaFigurer.cs
{
    public class Ellipse : Shape
    {
    
        public abstract double Area
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public abstract double Perimeter
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
      
        // Konstruktorn anropar baskonstruktorn och ser till att längd och bredd sätts till det nya objektet.
        public Ellipse(double length, double width) : base(length, width) {}
    }
}
