using System;
using Bakery.Models;
using Figgle;
namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine(FiggleFonts.Graffiti.Render("Welcome to Pierre's Bakery!"));
      Console.WriteLine("----Welcome to Pierre's Bakery!----");
      Console.ResetColor();
      Console.WriteLine("We got Bread, we got Pastry!");
      Console.WriteLine("You want? (Y/N)");
      string yOrN = (Console.ReadLine()).ToLower();
      if (yOrN == "y")
      {
        OrderMain();      
      }
      else if (yOrN == "n")
      {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Well, who needs ya, anyway? GO ON, GIT!");
        Console.ReadLine();
        Console.WriteLine(FiggleFonts.Ogre.Render("I SAID, GIT!"));
        Console.ResetColor();
      }
      else
      {
        Console.WriteLine("Sorry, I didn't catch that. Try again, please!");
        Console.ReadLine();
        Main();
      }
    }

    public static void OrderMain()
    {
      Console.WriteLine("Please tell us, which one do you want? (Bread/Pastry)");
      string userPurchaseChoice = (Console.ReadLine()).ToLower();
      if (userPurchaseChoice == "bread")
      {
        Console.WriteLine("Our bread costs $5 per loaf, but we've got good news! We've got a special on bread today: buy 2, get 1 free!");
        BreadOrder();
      }
      else if (userPurchaseChoice == "pastry")
      {
        Console.WriteLine("Great choice! Pastries around here go for $2 each, but today we've got a special: buy 2, get the 3rd half off!");
        PastryOrder();
      }
      else
      {
        Console.WriteLine("Unfortunately, I didn't catch that. Please try again.");
        Console.ReadLine();
        OrderMain();
      }
    }
    public static void BreadOrder()
    {
      Console.WriteLine("How many you want?!");
      string breadAmountInput = Console.ReadLine();
      int breadAmount;
      if (int.TryParse(breadAmountInput, out breadAmount))
      {
        Bread breadOrder = new Bread(breadAmount);
        int breadCost = breadOrder.BreadSpecialCost(breadAmount);
        Console.WriteLine($"Ok, {breadAmount} loaves will cost you ${breadCost}!");
        Console.WriteLine("Thanks, we'll see you soon!");
        Console.WriteLine(FiggleFonts.Shadow.Render("Have A Great Day!"));
      }
      else
      {
        Console.WriteLine("Sorry, we're looking for a numeric amount. Please try again!");
        Console.ReadLine();
        BreadOrder();
      }
    }

    public static void PastryOrder()
    {
      Console.WriteLine("How many can we interest you in?");
      string pastryAmountInput = Console.ReadLine();
      int pastryAmount;
      if (int.TryParse(pastryAmountInput, out pastryAmount))
      {
        Pastry pastryOrder = new Pastry(pastryAmount);
        int pastryCost = pastryOrder.PastrySpecialCost(pastryAmount);
        Console.WriteLine($"Alright, {pastryAmount} pastries will cost ya ${pastryCost}!");
        Console.WriteLine("Thanks, we'll see you soon!");
        Console.WriteLine(FiggleFonts.Shadow.Render("Have A Great Day!"));
      }
      else
      {
        Console.WriteLine("Sorry, we're looking for a numeric amount. Please try again!");
        Console.ReadLine();
        PastryOrder();
      }
    }
    
  }
}