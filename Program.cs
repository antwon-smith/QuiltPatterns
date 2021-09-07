using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltPatterns
{
    public class Program
    {
        // This whole section doesn't work.  Couldn't figure out how to call any methods I "think" I've created.

        public void RequestShape()
        {
            Console.WriteLine("Welcome to the Quilt Shape Recorder!\n\n\nS) Add a square\nR) Add a rectangle\nT) Add a triangle\nL) List shapes\n**********\nPlease select an option:\n**********");
            string selection = Console.ReadLine();

            if (selection.ToLower() == "s")
            {
                Square s;
                
            }
        }

        static void Main(string[] args)
        {
            //  Initially started here but realized I would need another method for requesting shapes since you can't re-run the Main method

            Console.WriteLine("Welcome to the Quilt Shape Recorder!\n\n\nS) Add a square\nR) Add a rectangle\nT) Add a triangle\nL) List shapes\n**********\nPlease select an option:\n**********");
            string selection = Console.ReadLine();

            if (selection.ToLower() == "s")
            {
                // Trying to call the CreateSquare() Method from the Square class.... unsuccessfully
                Square.CreateSquare(); 
            }
        }
    }
}
