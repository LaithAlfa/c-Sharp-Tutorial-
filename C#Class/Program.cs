using System;

namespace C_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Dune", "Frank Herbert", 665);
            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);
        }
    }
}
