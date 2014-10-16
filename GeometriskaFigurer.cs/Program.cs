﻿using System;
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

            do
            {
                Console.Clear();
                ViewMenu();

                try
                {
                int index = int.Parse(Console.ReadLine());
                    switch (index)
                    {
                        case 0:
                            return;

                        case 1:
                            ViewShapeDetail(CreateShape(ShapeType.Ellipse));
                            break;

                        case 2:
                            ViewShapeDetail(CreateShape(ShapeType.Rectangle));
                            break;

                        default:
                            throw new ArgumentException();
                    }
                }

                catch
                {
                    // Visar felmeddelande om inmatat värde är utanför intervallet (0-2).
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFEL! Ange ett nummer mellan 0 och 2.\n");
                    Console.ResetColor();

                    // Ger användaren ny chans att ange ett korrekt menyalternativ.
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write("\nTryck tangent för att fortsätta");
                    Console.ResetColor();
                }

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);  
        }
            
        private static Shape CreateShape(ShapeType shapeType)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n===================================");

            switch (shapeType) 
            {
                case ShapeType.Ellipse:Console.WriteLine("=             Ellipse             =");
                    break;

                case ShapeType.Rectangle:Console.WriteLine("=            Rectangle            =");
                    break;
            }

            Console.WriteLine("===================================\n");
            Console.ResetColor();

            double length = ReadDoubleGreaterThanZero("Ange längd: ");
            double width = ReadDoubleGreaterThanZero("Ange bredd: ");

            if (shapeType == ShapeType.Ellipse)
            {
                return new Rectangle(length, width);
            }
            else
            {
                return new Ellipse(length, width);
            }
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {

            while (true)
            {
                Console.Write(prompt);

                try
                {
                    double variable = double.Parse(Console.ReadLine());

                    if (variable <= 0)
                    {
                        throw new Exception();
                    }
                }

                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFEL! Ange ett flyttal större än 0.");
                    Console.ResetColor();
                }
            }
        }

        // Presentation av meny.
        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n===================================");
            Console.WriteLine("=                                 =");
            Console.WriteLine("=       Geometriska figurer       =");
            Console.WriteLine("=                                 =");
            Console.WriteLine("===================================\n");
            Console.ResetColor();
            Console.WriteLine("\n0. Avsluta.\n");
            Console.WriteLine("1. Ellips.");
            Console.WriteLine("\n2. Rektangel.\n");
            Console.WriteLine("\n===================================\n");

            Console.Write("Ange menyval [0-2]: ");
        }

        // Presentation av en figurs detaljer (Längd, Höjd, Omkrets och Area).
        private static void ViewShapeDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===================================");
            Console.WriteLine("=            Detaljer             =");
            Console.WriteLine("===================================\n");
            Console.ResetColor();

            Console.WriteLine(shape.ToString());

            Console.WriteLine("\n===================================\n");
        }
    }
}
