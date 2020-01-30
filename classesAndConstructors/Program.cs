using System;

namespace BookClass
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Book book1 = new Book("lord of the rings", "tolkien", 500);


      Console.WriteLine(book1.title);
    }
  }
}
