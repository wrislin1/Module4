/* 
 Widler Rislin
 10/10/2019
 CEN 4370C
 Module 4 Assignment
 This Program prompts the user for input to find the area of either a Circle, Square or Rectangle.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt = 0; // Variable holding user selection
            double area; // variable holding area value.

            while (opt != 4) // Loops through selection menu, checks for escape character.
            {
                opt = 0; // resets user selection to 0
                Console.WriteLine("Please enter a selection");    // Selection Menu
                Console.WriteLine("1. Area of a Circle");
                Console.WriteLine("2. Area of a Rectangle");
                Console.WriteLine("3. Area of a Triangle");
                Console.WriteLine("4. Exit Program");
                Console.WriteLine();

                try //Checking for invalid inputs
                {
                    opt = int.Parse(Console.ReadLine());
                    if (opt < 1 || opt > 4)
                        throw new Exception();
                }
                catch
                {
                    Console.WriteLine();
                    Console.Write("Input Not Valid, Please try again: ");    // Prompts user for new input
                    Console.WriteLine();
                    
                }
                switch(opt)   // Checks user selection and switches to case that calls the proper function
                {
                    case 1:
                        area = AreaCircle();   // Calls function to sets area
                        if (area==0)     // If area is 0 the eescape character was pressed
                        {
                            break;
                        }
                        Console.WriteLine();
                        Console.WriteLine("Area of the Circle = " + area); //outputs area
                        break;
                    case 2:
                        area = AreaRectangle();  
                        if (area == 0)
                        {
                            break;
                        }
                        Console.WriteLine();
                        Console.WriteLine("Area of the Rectangle = " + area);
                        break;
                    case 3:
                        area = AreaTriangle();
                        if (area == 0)
                        {
                            break;
                        }
                        Console.WriteLine();
                        Console.WriteLine("Area of the Triangle = " + area);
                        break;
                }
                Console.WriteLine();
            }
        }
        static double AreaCircle() // Circle area function
        {
            string c;       // escape character check
            double radius=0;

            Console.WriteLine();
            Console.WriteLine("Press x to return to the Menu");
            Console.WriteLine();                                 // Prompts user for input
            Console.Write("Please enter the Radius of the Circle: ");

            while (radius <= 0)
            {
                c = Console.ReadLine(); // stores user input
                if (c == "x" || c == "X")  // checks for escape character
                {
                    return 0;
                }
                try // checks for valid input
                {
                    radius = double.Parse(c);
                    if(radius<=0)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.Write("Invalid Input, Please enter a valid Radius: "); // prompts user for valid input

                }
            }
            double a = Math.PI * Math.Pow(radius, 2); // calculates area
            return a; //returns area to main
        }

        static double AreaRectangle() // Rectangle Arera Function
        {
            string c; // escape character check
            double b = 0, h = 0;

            Console.WriteLine();
            Console.WriteLine("Press x to return to the Menu");
            Console.WriteLine(); //prompts user for input
            Console.Write("Please enter the Base of the Rectangle: ");

            while (b <= 0)
            {
                c = Console.ReadLine(); // stores user input
                if (c == "x" || c == "X") // checks for escape character
                {
                    return 0;
                }
                try // checks for valid input
                {
                    b = double.Parse(c);
                    if (b <= 0)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.Write("Invalid Input, Please enter a valid Base: "); //prompts user to enter valid input

                }
            }
            Console.Write("Please enter the Height of the Rectangle: ");

            while (h <= 0)
            {
                c = Console.ReadLine();
                if (c == "x" || c == "X")
                {
                    return 0;
                }
                try
                {
                    h = double.Parse(c);
                    if (h <= 0)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.Write("Invalid Input, Please enter a valid Height: ");

                }
            }
            double a = b * h; // Calculates area
            return a; // returns area to main


        }

        static double AreaTriangle() // Area of Triangle Function
        {
            string c; // escape character check
            double b = 0, h = 0;

            Console.WriteLine();
            Console.WriteLine("Press x to return to the Menu");
            Console.WriteLine(); //prompts user for inout
            Console.Write("Please enter the Base of the Triangle: ");
            

            while (b <= 0)

            {
                c = Console.ReadLine(); // stores user input

                if (c == "x" || c == "X") // checks for escape character
                {
                    return 0;
                }
                try // checks for valid input
                {
                    b = double.Parse(c);
                    if (b <= 0)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.Write("Invalid Input, Please enter a valid Base: "); // prompts user for valid input

                }
            }
            Console.Write("Please enter the Height of the Triangle: ");

            while (h <= 0)
            {
                c = Console.ReadLine();
                if (c == "x" || c == "X")
                {
                    return 0;
                }
                try
                {
                    h = double.Parse(c);
                    if (h <= 0)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.Write("Invalid Input, Please enter a valid Height: ");

                }
            };
            double a = (b * h)/ 2; // calculate area
            return a; // return area to main.


        }
    }
}
