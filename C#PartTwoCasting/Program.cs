using System;

namespace C_PartTwoCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------Implicit Casting-------------------------//
            int number1 = 9;
            int number2 = 42;
            int sum = number2 / number1;

            double myDouble = sum;

            Console.WriteLine(sum);
            Console.WriteLine("/--------Casting from a Integer to a double. Implicit Casting------/");
            Console.WriteLine(myDouble);
            //----------------------------------------------------------//


            //------------------Explicit Casting -----------------------//
            double myDouble1 = 9.78;
            int myInt = (int) myDouble1;

            Console.WriteLine(myDouble1);
            Console.WriteLine("/--------Casting from a double to an integer. Explecit Casting------/");
            Console.WriteLine(myInt);
            //---------------------------------------------------------//

            //-----------------Type of conversion Methods-------------//
            int myInt1 = 10;
            double myDouble2 = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt1));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt1));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble2));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string







        }
    }
}
