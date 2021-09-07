using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltPatterns
{
    public class Square : Shape
    {
        public int side1;

        // Setting properties of square
        public Square(string color, int side)
        {
            Name = "Square";
            Color = color;
            side1 = side;
        }
        
        // Method to create square
        public Shape CreateSquare()
        {
            
            Console.WriteLine("You have chosen to add a square.  Please select a side length.");
            int side1 = Convert.ToInt32(Console.ReadLine());
            int area = side1 * side1;

            Console.WriteLine("Type a color for your new square.");
            string color = Console.ReadLine();

            Console.WriteLine($"You have created a {color} square with an area of {area}!");
            return new Square(color, side1);
        }
    }
}        
        
    
       
    

