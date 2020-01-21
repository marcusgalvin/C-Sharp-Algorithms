using System;

namespace firstDupe
{
  class MainClass
  {
    public static void Main()
    {
      int[] array = { 2, 1, 3, 5, 3, 2 };
      //int[] arrayTwo = { 2, 1, 3, 5, 3, 2 };
      //int counter = 1;



      for (var i = 0; i < array.Length; i++)
      {

        for (var j = i + 1; j < array.Length; j++)
        {



          if (array[i] == array[j])
          {

            int[] test = { array[j] };

            for (var k = 0; i < test.Length; k++)
            {
              //find the first dupe, which is 2
              var firstDupe = test[0];
              Console.WriteLine("first dupe {0}:", firstDupe);




              //find the index of the first dupe in the main array, it equals 0
              int first = Array.IndexOf(test, firstDupe);
              Console.WriteLine("first dupes index {0}:", first);


              //public static void Clear(Array array, int index, int length);


              Array.Clear(array, first, 1);
              Console.WriteLine(newArray);

              //add one to that index to now search for the second index
              //int addOne = first + 1;
              //Console.WriteLine(addOne);



              //int second = Array.IndexOf(test, firstDupe); // will be 7
              //Console.WriteLine(second);

              break;

            }



          }






        }

      }

    }
  }
}