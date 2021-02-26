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
      Console.WriteLine("You want? (Y/N)");
      string yOrN = (Console.ReadLine()).ToLower();
      if (yOrN == "y")
      {
      Console.WriteLine("Please tell us, which one you want:");
      string userPurchaseChoice = (Console.ReadLine()).ToLower();
      if (userPurchaseChoice == "bread")
      {
        Console.WriteLine("Good news! We've got a special on bread today: buy 2, get 1 free!");
        Console.WriteLine("How many you want?!");
        string breadAmountInput = Console.ReadLine();
        int breadAmount;
        if (int.TryParse(breadAmountInput, out breadAmount))
        {
          Console.Write("parse");
        }
        else
        {
          Console.WriteLine("Sorry, we're looking for a numeric amount. Please try again!");
          //ENTER BACK TO BREAD METHOD
        }
      else if (userPurchaseChoice == "pastry")
      {
        Console.WriteLine("Great choice! Pastries around here go for $2 each, but today we've got a special: buy 2, get the 3rd half off!");
        Console.WriteLine("How many can we interest you in?");
        string pastryAmountInput = Console.ReadLine();
        int pastryAmount;
        if (int.TryParse(pastryAmountInput, out pastryAmount))
        {
          Console.Write("parse");
        }
        else
        {
          Console.WriteLine("Sorry, we're looking for a numeric amount. Please try again!");
          //ENTER BACK TO BREAD METHOD
        }
      }
      }
      }
      else if (yOrN == "n")
      {
        Console.WriteLine("Well, who needs ya, anyway? GO ON, GIT!");
      }
      else
      {
        Console.WriteLine("Sorry, I didn't catch that. Try again, please!");
        Console.ReadLine();
        Main();
      }
    }
  }
}