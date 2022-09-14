using System;
using OperatorExercise;
namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        
        
        
        
        
        
        
        
        {
            //Exercise 1:
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;
            //
            if (a == 17 && b == 4)

                //String Concatination
                //Console.WriteLine(a + " / " + b + "is " + quotient + "remainder" + remainder);

                //String Interprolation
                Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of a circle with radius of {radius} is {area}");
        }
         
        
    }
}