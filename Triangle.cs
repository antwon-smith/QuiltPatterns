using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltPatterns
{
    public class Triangle : Shape
    {
        public int firstSide;
        public int secondSide;
        public int thirdSide;

        // Setting properties of triangle
        public Triangle(string color, int side1, int side2, int side3)
        {
            Name = "Triangle";
            Color = color;
            firstSide = side1;
            secondSide = side2;
            thirdSide = side3;
        }

        // Method to create Triangle
        public Shape CreateTriangle()
        {

            Console.WriteLine("You have chosen to add a Triangle.  Please select first side length:");
            int side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you. Please select second side length:");
            int side2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you. Please select the final side length:");
            int side3 = Convert.ToInt32(Console.ReadLine());

            int s = (int)((side1 + side2 + side3)/2.0d);
            decimal area = (decimal)Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3)); 

            Console.WriteLine("Type a color for your new Triangle.");
            string color = Console.ReadLine();

            Console.WriteLine($"You have created a {color} Triangle with an area of {area}!");
            return new Triangle(color, side1, side2, side3);
        }

        // Attempt to call the requst shape method in program class.  Not sure how to, or what is wrong here
        Program.RequestShape();
    }
}
