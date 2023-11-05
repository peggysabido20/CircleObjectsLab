namespace CircleObjectsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(0);
            Console.WriteLine("Welcome to the Circle Tester");
            double radius = circle.GetRadius();
            bool userWantsToContinue = false;
            while (true)
            {                
                double diameter = circle.CalculateDiameter();
                double circumference = circle.CalculateCircumference();
                double circleArea = circle.CalculateArea();
                Console.WriteLine($"Diameter: {diameter}");
                Console.WriteLine($"Circumference: {circumference}");
                Console.WriteLine($"Area: {circleArea}");
                userWantsToContinue = Validator.wantToContinue();
                if (userWantsToContinue)
                {
                    Console.WriteLine("The circle is magically growing.");
                    Console.WriteLine("");
                    circle.Grow();
                }
                else
                {
                    Console.WriteLine($"The circle's original radius was {radius}");
                    Console.WriteLine($"Goodbye. The circle's final radius is {circle.Radius}");                    
                    break;
                }
            }
        }     
    }
}