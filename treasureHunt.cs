using System;

//instructions: given a starting coordinate and a list of strings determine the location of the treasure
//start = [x,y]
//instruction = {"N3","E2","S5","W10"}

// coorordinates = the first number shows the distance along, and the second number shows the distance up or down


namespace TreasureHunt
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      var numbers = new int[2];
      //deals with height
      numbers[0] = 1;
      //deals with width
      numbers[1] = 100;
      Console.WriteLine("starting point {0}, {1}", numbers[0], numbers[1]);

      //order of treaure location: north, east, south, west
      var treasure = new int[4] { 3, 2, 5, 10 };
      //Console.WriteLine("end point", treasure);

      //Console.WriteLine(treasure[0]);



      for (int i = 0; i < treasure.Length; i++)
      {

        if (numbers[0] > treasure[i])
        {
          var north = (numbers[0] - treasure[i]);

          var n = numbers[0] - north;

          //Console.WriteLine(north);
          Console.WriteLine(n);

        }
        else
        {
          var test = (treasure[i] - numbers[0]);
          var lower = numbers[0] + test;

          //Console.WriteLine(test);
          Console.WriteLine(lower);

        }

      }

    }
  }
}