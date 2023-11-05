using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjectsLab
{
    public class Circle
    {
        public Circle(double radius) 
        {
            Radius = radius;       
        }

        public double Radius { get; set; }
        public double Diameter { get; set; }
        public double Circumference { get; set; }
        public double CircleArea { get; set; }

        public double CalculateDiameter()
        {
            Diameter = (Radius * 2);
            return Diameter;
        }

        public double CalculateCircumference()
        {
            Circumference = Math.Round((Diameter * Math.PI), 2);
            return Circumference;
        }

        public double CalculateArea()
        {
            CircleArea = Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
            return CircleArea;
        }

        public void Grow()
        {
            Radius = (Radius * 2);
        }

        public double GetRadius()
        {
            while (true)
            {
                Console.Write("Enter radius: ");
                string userRadius = Console.ReadLine();
                double validDouble = Validator.validDouble(userRadius);
                if (validDouble == 0)
                {
                    continue;
                }
                else if (validDouble < 0)
                {
                    Console.WriteLine("Radius cannot be negative. Try again.");
                    continue;
                }
                else
                {
                    Radius = validDouble;
                    return Radius;
                }
            }
        }       
    }
}
