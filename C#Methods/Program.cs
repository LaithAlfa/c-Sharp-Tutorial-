using System;

namespace C_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethod();
             Console.WriteLine("Please input a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input a second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = ComparingIngeres(number1 , number2, number3);

            Console.WriteLine(result);
        }

        static void MyMethod()
        {
            Console.WriteLine("MyMethod works");
        }


        static void ComparingIngeres ()
        {
            if (num1 > num2)
            {
                Console.WriteLine(num2 + ": is Larger");
                Console.WriteLine(num1 + ": is Smaller");
            }
            else if(num1 < num2)
            {
              Console.WriteLine(num1 + ": is Larger");
                Console.WriteLine(num2 + ": is Smaller"); 
               
            }
            else
            {
               Console.WriteLine("These numbers are equal");


            }
        }
    }
}
