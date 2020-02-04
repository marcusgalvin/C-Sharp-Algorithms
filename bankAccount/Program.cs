using System;

//create a savings interest account that does the following:
//has a starting balance
//amt of time in years
//monthly interest rate
//auto deposit system(amt and occurance) - applied post interest gain
//auto withdraw system (amt and occurance) - applied pre interest gain
//return the balance


namespace BankAccountDemo
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Account AccountOne = new Account(1, "Marcus", 100.47, 0.7, "Checking");
      Console.WriteLine(AccountOne.balance);
    }

    public void calcInterest()
    {

    }
  }
}