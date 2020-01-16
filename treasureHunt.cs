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
      numbers[0] = 100;
      //deals with width
      numbers[1] = 10;
      Console.WriteLine("starting point {0}, {1}", numbers[0], numbers[1]);

      //order of treaure location: north, east, south, west
      var treasure = new int[4] { 3, 2, 5, 10 };


      //this finds the treasure location coorordinates

      //x axis
      //3 steps north and 5 steps south = negative 2
      //Math.abs helps find the differential in steps

      var coordinateOne = Math.Abs(treasure[0] - treasure[2]);
      var coordinateOneLoc = numbers[0] - coordinateOne;
      Console.WriteLine("x axis coorordinate {0}", coordinateOneLoc);

      //y axis
      //2 steps east and one 10 steps west = 8
      var coordinateTwo = Math.Abs(treasure[1] - treasure[3]);
      var coordinateTwoLoc = numbers[1] + coordinateTwo;
      Console.WriteLine("y axis coorinate {0}", coordinateTwoLoc);


      //extra step - read the instructions wrong at first
      //this conditional locates how many steps in each direction to take, in this order (N,E,S,W)
      Console.WriteLine("Below are how many steps the user takes");
      for (int i = 0; i < treasure.Length; i++)
      {

        if (numbers[0] > treasure[i])
        {
          var north = (numbers[0] - treasure[i]);

          var n = numbers[0] - north;

          //Console.WriteLine("n/s corrordinate {0}", north);
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
