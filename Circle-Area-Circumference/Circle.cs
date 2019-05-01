using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area_Circumference
{
    public class Circle
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetCircumference()
        {
            //Circumference = 2 × π × Radius
            return Math.Round((2 * Math.PI) * radius,2); 
        }
        public double GetArea()
        {
            //The Area = π r2
            return Math.Round(Math.PI * Math.Pow(radius, 2),2);
        }

        public void PrintInfo()
        {
            //using the other methods this should print the following in this order:
            //The Radius
            //The Area
            //The Circumference
            //Circumference: 18.85
            //Area: 28.27
            Console.WriteLine("Radius: "+ radius);
            Console.WriteLine("Circumference: " + GetCircumference());
            Console.WriteLine("Area: " + GetArea());
        }
    }
}
