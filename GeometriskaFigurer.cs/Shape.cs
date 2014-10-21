using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometriskaFigurer.cs
{
    public enum ShapeType { indefenit, Ellipse, Rectangle };

    public abstract class Shape
    {
        private double _length;
        private double _width;

        public abstract double Area
        {
            get;
        }

        // Egenskap som kapslar in 'Length'.
        public double Length
        {
            get { return _length; }    
            set
            {
                if (_length < 0)
                {
                    throw new ArgumentException();
                }

                _length = value;
            }
        }

        public abstract double Perimeter
        {
            get;
        }
        
        // Egenskap som kapslar in 'Width'.
        public double Width
        {
            get { return _width; }
            set
            {
                if (_width < 0 )
                {
                    throw new ArgumentException();
                }

                _width = value;
            }
        }

        // Överskuggar 'ToString' och returnerar värdena för Längd, Bredd, Omkrets och Area.
        public override string ToString()
        {   
            return string.Format("{0,-10}:{1,10:F2}\n{2,-10}:{3,10:F2}\n{4,-10}:{5,10:F2}\n{6,-10}:{7,10:F2}\n", "Längd", Length, "Höjd", Width, "Omkrets", Perimeter, "Area", Area);
        }

        // Konstruktorn ser till att fälten tilldelas de värden konstruktorns parametrar har.
        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }

    }
}
