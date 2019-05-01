using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area_Circumference
{
    class CircleApp
    {
        public List<Circle> Circles = new List<Circle>();

        public void Run()
        {
            //bool isValidUserInput = false;
            //double userInput = 0;
            bool doAgain = true;
            while (doAgain)
            {
                Console.WriteLine("Please enter the radius of a circle: ");
                bool isValidUserInput = Double.TryParse(Console.ReadLine(), out double userInput);
                if (isValidUserInput && userInput > 0)
                {
                    Circle c = new Circle(userInput);
                    Circles.Add(c);
                }
                else
                {
                    Console.WriteLine("Not a valid input");
                    continue;
                }
                bool askToEnterAnotherCircle = true;
                while (askToEnterAnotherCircle)
                {
                    Console.WriteLine("Would you like to add another circle? (yes or no)");
                    string userInput2 = Console.ReadLine();
                    if(userInput2.ToLower() == "yes" || userInput2.ToLower() == "y")
                    {
                        askToEnterAnotherCircle = false;
                    }
                    else if(userInput2.ToLower() == "no" || userInput2.ToLower() == "n")
                    {
                        askToEnterAnotherCircle = false;
                        doAgain = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid response please enter yes or no");
                    }
                }

            }
            PrintCircles();
        }
        
        public void PrintCircles()
        {
            Console.WriteLine("Number of circles: " + Circles.Count());
            foreach (Circle circle in Circles)
            {
                circle.PrintInfo();
            }
        }
    }
}
