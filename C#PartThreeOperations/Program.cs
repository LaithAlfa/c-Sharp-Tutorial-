using System;

namespace C_partThreeOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");

            String userName = Console.ReadLine();

            Console.WriteLine("Welcome " + userName);
            //-------------------------------------//

            Console.WriteLine("/-----------------------------------------/");
            
            Console.WriteLine("Please enter your age");

            double age = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your age is " + age);

            
        }
    }
}
