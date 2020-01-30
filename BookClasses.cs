using System;

namespace BookClass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "lord of the rings";
            book1.author = "tolkien";
            book1.pages = 500;

            Console.WriteLine(book1.title);
        }
    }
}