using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometriskaFigurer.cs
{
    public abstract class Shape
    {
        // Initiera och deklarera variabler.
        private double _length = 0;
        private double _width = 0;

        public abstract double Area
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        // Egenskap som kapslar in '_length'.
        public double Length
        {
            get { return _length; }    
            set
            {
                if (_length <= 0)
                {
                    throw new ArgumentException();
                }

                _length = value;
            }
        }

        public abstract double Perimeter
        {
            get { throw new System.NotImplementedException(); }
        }
        
        // Egenskap som kapslar in '_width'.
        public double Width
        {
            get { return _width; }
            set
            {
                if (_width <=0 )
                {
                    throw new ArgumentException();
                }

                _width = value;
            }
        }

        // Överskuggar 'ToString' och returnerar värdena för Längd, Bredd, Omkrets och Area.
        public override string ToString()
        {
            return String.Join("Längd{-10:10}{0}\n Bredd{-10:10}{1}\n Omkrets{-10:10}{2}\n Area{-10:10}{3}\n", Length, Width, Perimeter, Area);
        }

        // Konstruktorn ser till att fälten tilldelas de värden konstruktorns parametrar har.
        protected Shape(double length, double width)
        {
            Length = _length;
            Width = _width;
        }

    }
}
