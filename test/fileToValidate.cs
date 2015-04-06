using System;

namespace StyleCop.Test {
  public class HelloWorld {
    public void SayHello(int input = 1)
    {
      if (input > 0)
        Console.WriteLine("Hello World!");
    }
  }
}