using System;

namespace Movies
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Movie avengers = new Movie("avengers", "bob", "PG-13");
      Movie shrek = new Movie("shrek", "jim", "PG");

      Console.WriteLine(shrek.rating);

    }
  }
}