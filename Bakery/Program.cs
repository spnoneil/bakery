using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("----Welcome to Pierre's Bakery!----");
      Console.WriteLine("We got Bread, we got Pastry!");
      Console.WriteLine("You want Bread, and/or Pastry? (Y/N)");
      string yOrN = (Console.ReadLine()).ToLower();
      if (yOrN == "y")
      {
      Console.WriteLine("Please tell us, which one you want:");
      string userPurchaseChoice = (Console.ReadLine()).ToLower();
      if (userPurchaseChoice == "bread")
      {
        Console.WriteLine("Good news! We've got a special on bread today; buy 2, get 1 free!");
        Console.WriteLine("How many you want?!");
        int breadAmount = int.Parse(Console.ReadLine());
        // if (breadAmount == int)

      }
      }
      else if (yOrN == "n")
      {
        Console.WriteLine("Well, who needs ya, anyway? GO ON, GIT!");
      }
      else
      {
        Console.WriteLine("Sorry, I didn't catch that. Try again, please!");
        Main();
      }
    }
  }
}