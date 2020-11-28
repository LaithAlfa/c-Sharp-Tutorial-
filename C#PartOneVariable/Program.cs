using System;

namespace C_PartOneVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------Syntax Example 1.1------------------//
            Console.WriteLine("Hello World");
            Console.WriteLine("My out put will be on a new line");
            
            Console.Write("Hello World. ");
            Console.Write(" My output will be on the same line.");
            Console.WriteLine(" ");

            //-----------------------------------------------------//

            //------------Declaring Variables Example 1.2----------//
            Console.WriteLine("/------------------------------------------------------/");
            int numberExample = 10; //interger Variable
            string myName = "John Deer"; //String Variable
            bool trueOrfales = true; //Boolean Variable
            double d = 0.42e2; //Double Variable
            float f = 134.45E-2f; //Float Variable
            decimal m = 1.5E6m; //Decimal Variable

            Console.WriteLine("Interger variable: " + numberExample);
            Console.WriteLine("Sting variable: " + myName);
            Console.WriteLine("Boolean variable: " + trueOrfales);
            Console.WriteLine("Double variable: " + d);
            Console.WriteLine("Float variable: " + f);
            Console.WriteLine("Decimal variable: " + m);
        }
    }
}
