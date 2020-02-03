using System;

namespace Inheritance

{


  class MainClass
  {
    public static void Main(string[] args)
    {
      Chef chef = new Chef();
      chef.makeBurger();
      chef.makeSpecial();

      Chef SpanishChef = new Chef();
      SpanishChef.makePizza();
      SpanishChef.makeSpecial();
    }
  }
}
