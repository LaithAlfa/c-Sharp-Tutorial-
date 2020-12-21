using System;

namespace C_methods
{
    class Program
    {
        static void Main(string[] args)
        {
           meetAlien();
            Console.WriteLine("Please input a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input a second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            ComparingIntegers(num1, num2);
        }

        static void meetAlien()
        {
            Random numberGen = new Random();

            string name = "x-" + numberGen.Next(10, 999);
            int age = numberGen.Next(10,999);
            Console.WriteLine("Hi, I'm "+ name);
            Console.WriteLine("I'm "+ age);
            Console.WriteLine("OH, and I'm an alien");
                       
        }

        static int ComparingIntegers(int num1, int num2)
        {
            int largeValue = 0;

            if (num1 < num2)
            {
                largeValue = num2;
                Console.WriteLine(largeValue + ": is Larger");

            }else if (num1 > num2)
            {
                largeValue = num1;
                Console.WriteLine(largeValue + ": is Larger");

            }else
            {
                Console.WriteLine("These numbers are equal");
            }

            return largeValue;

        }
        
    }
}
