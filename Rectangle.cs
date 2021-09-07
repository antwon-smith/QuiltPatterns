using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltPatterns
{
    public class Rectangle : Shape
    {
        public int firstSide;
        public int secondSide;
        
        // Setting properties of rectangle
        public Rectangle(string color, int side1, int side2)
        {
            Name = "Rectangle";
            Color = color;
            firstSide = side1;
            secondSide = side2;
        }

        // Method to create rectangle
        public Shape CreateRectangle()
        {

            Console.WriteLine("You have chosen to add a Rectangle.  Please select first side length:");
            int side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you. Please select second side length:");
            int side2 = Convert.ToInt32(Console.ReadLine());

            int area = side1 * side2;

            Console.WriteLine("Type a color for your new square.");
            string color = Console.ReadLine();

            Console.WriteLine($"You have created a {color} square with an area of {area}!");
            return new Rectangle(color, side1, side2);
        }

        // Attempt to call the requst shape method in program class.  Not sure how to, or what is wrong here
        Program.RequestShape();
    }
}
