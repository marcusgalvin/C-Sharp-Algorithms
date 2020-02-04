namespace BankAccountDemo
{
  public class Account
  {
    public int id;
    public string name;
    public double balance;
    public double interestRate;
    public string type;
    //public double[] transactions;


    public Account(int aId, string aName, double aBalance, double aInterestRate, string aType)
    {
      id = aId;
      name = aName;
      balance = aBalance;
      interestRate = aInterestRate;
      type = aType;
      //transactions = aTransactions;

    }

    //public void calcInterest(interestRate)
    //{

    //}
  }
}