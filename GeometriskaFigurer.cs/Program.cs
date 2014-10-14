using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer.cs
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static Shape CreateShape()
        {
            throw new System.NotImplementedException();
        }

        private static double ReadDoubleGreaterThanZero()
        {
            throw new System.NotImplementedException();
        }

        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("===================================");
            Console.WriteLine("=                                 =");
            Console.WriteLine("=       Geometriska figurer       =");
            Console.WriteLine("=                                 =");
            Console.WriteLine("===================================\n");
            Console.ResetColor();
            Console.WriteLine("0. Avsluta.");
            Console.WriteLine("1. Ellips.");
            Console.WriteLine("2. Rektangel.");
            Console.WriteLine("\n===================================\n");
            Console.WriteLine("Ange menyval [0-2]:");
        }

        private static void ViewShapeDetail()
        {
            throw new System.NotImplementedException();
        }
    }
}
