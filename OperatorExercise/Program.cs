namespace OperatorExercise
{
    class Program
    {
        static void Main()
        {
            int a = 17;
            int b = 4;
            
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b; 
            int remainder = a % b; 
            
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            
            double area = AreaOfCircle(radius);
            
            Console.WriteLine($"The area of a circle with radius of {radius} is {area}");
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            static double AreaOfCircle(double radius)
            {
                return Math.PI * Math.Pow(radius, 2);
            }
        }
    }
}    
