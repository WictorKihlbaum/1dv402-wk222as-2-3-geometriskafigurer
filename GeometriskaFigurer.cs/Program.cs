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
            int index;

            ViewMenu();

            do
            {

                if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index <= 2)
                {
                    switch (index)
                    {
                        case 0:
                            return;

                        case 1:
                            CreateShape(ShapeType.Ellipse);
                            break;

                        case 2:
                            CreateShape(ShapeType.Rectangle);
                            break;
                    }

                    // Visar felmeddelande om inmatat värde är utanför intervallet (1-2).
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEL! Ange ett nummer mellan 0 och 2.");
                    Console.ResetColor();
                }
                // Ger användaren ny chans att ange ett korrekt menyalternativ.
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write("\nTryck tangent för att fortsätta");
                Console.ResetColor();
                Console.CursorVisible = false;
                Console.ReadKey(true);
                Console.Clear();
                Console.CursorVisible = true;

            } while (true);
        }
            

        private static Shape CreateShape(ShapeType shapeType)
        {
            throw new System.NotImplementedException();
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            throw new System.NotImplementedException();
        }

        // Presentation av meny.
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
        }

        // Presentation av en figurs detaljer (Längd, Höjd, Omkrets och Area).
        private static void ViewShapeDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("===================================");
            Console.WriteLine("=            Detaljer             =");
            Console.WriteLine("===================================");
            Console.ResetColor();

            Console.WriteLine(shape.ToString());

            Console.WriteLine("\n===================================\n");
        }
    }
}
