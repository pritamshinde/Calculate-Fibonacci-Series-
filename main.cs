/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld
{
  static void Main (string[]args)
  {
    Console.
      WriteLine
      ("Please enter a numeric/positive and greater than zero argument.");
    string val;
      val = Console.ReadLine ();
    int num = Convert.ToInt32 (val);

    if (num != null && num > 0)
      {
	Fibonacci_Series (num);
      }
    else
      {
	Console.
	  WriteLine
	  ("Please enter a numeric/positive and greater than zero argument.");
      }

  }

  public static void Fibonacci_Series (int len)
  {
    int a = 0, b = 1, c = 0;
    Console.Write ("{0} {1}", a, b);
    for (int i = 2; i < len; i++)
      {
	c = a + b;
	Console.Write (" {0}", c);
	a = b;
	b = c;
      }
  }
}
