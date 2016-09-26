using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassAssignment2_NET
{
    class Tester
    {
        static void Main(string[] args)
        {

            Shape rectangle = new Rectangle(4,6);
            Shape triangle = new Triangle(8, 4);
            Shape circle = new Circle(6);

            DisplayInfo(rectangle);
            DisplayInfo(triangle);
            DisplayInfo(circle);

            Console.WriteLine("\n Press enter to end program...");
            Console.ReadLine();
        }

        public static void DisplayInfo(Shape s)
        {
            Console.WriteLine("The area of the {0} is {1}", s.ToString(), s.getArea());
        }
    }
}