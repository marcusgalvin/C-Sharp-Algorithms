using System;

namespace Inheritance
{
  public class Chef
  {
    public void makeBurger()
    {
      Console.WriteLine("The chef makes a Burger");
    }

    public void makePizza()
    {
      Console.WriteLine("The chef makes a Pizza");
    }


    //make this method virtual in order to be able to override it for use with multiples classes
    public virtual void makeSpecial()
    {
      Console.WriteLine("The chef makes Lobster");
    }
  }
}