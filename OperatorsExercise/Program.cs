using System;

namespace OperatorsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Exercise 1 =====");
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int mod = a % b;

            Console.WriteLine($"{a}/{b} = {quotient} remainder {mod}");

            Console.WriteLine("==== Exercise 2 =====");
            PrintAreaOfCircle();

            Console.WriteLine("===== Thought Exercise =====");
            var i = 3;
            var j = 4;
            var k = ++i * j++;
            Console.WriteLine(k);

        }

        public static void PrintAreaOfCircle()
        {            
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of your circle is {area}.");
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
