using System;

namespace Inheritance

{
  public class SpanishChef : Chef
  {

    public override void makeSpecial()
    {
      Console.WriteLine("The chef makes Lobster");
    }

    public void makeJambalaya()
    {
      Console.WriteLine("The chef makes Jambalaya");
    }



  }
}