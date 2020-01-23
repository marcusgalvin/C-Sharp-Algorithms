using System;

namespace fareEstimator
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      int rideTime = 30;
      int rideDistance = 7;
      double[] costPerMin = { 0.2, 0.35, 0.4, 0.45 };
      double[] costPermile = { 1.1, 1.8, 2.3, 3.5 };


      for (var i = 0; i < costPerMin.Length; i++)
      {

        var first = costPerMin[i] * rideTime;
        Console.WriteLine("first calculation: {0}", first);


        var second = costPermile[i] * rideDistance;
        Console.WriteLine("second calculation: {0}", second);

        var answer = first + second;
        Console.WriteLine("answer: {0}", answer);
      }

    }
  }
}



//Expected Output:
//[13.7, 23.1, 28.1, 38]

//(Cost per minute) * (ride time) + (Cost per mile) * (ride distance)