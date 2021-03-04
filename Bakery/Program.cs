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
      Console.WriteLine("We got Bread, we got Pastry!\nYou want? (Y/N)");
      string yOrN = (Console.ReadLine()).ToLower();
      if (yOrN == "y")
      {
        OrderMain();      
      }
      else if (yOrN == "n")
      {
        YouSaidNo();
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
      Console.WriteLine("How many loaves you want?!");
      string breadAmountInput = Console.ReadLine();
      int breadAmount;
      if (int.TryParse(breadAmountInput, out breadAmount))
      {
        if (breadAmount > 0)
        {
        Bread breadOrder = new Bread(breadAmount);
        int breadCost = breadOrder.BreadSpecialCost();
        Console.WriteLine($"Ok, {breadAmount} loaves will cost you ${breadCost}!\nThanks, we'll see you soon!");
        Console.WriteLine(FiggleFonts.Shadow.Render("Have A Great Day!"));
        }
        else
        {
          Console.WriteLine("Please enter a positive number!");
          BreadOrder();
        }
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
      Console.WriteLine("How many of our FOINE pastries can we interest you in?");
      string pastryAmountInput = Console.ReadLine();
      int pastryAmount;
      if (int.TryParse(pastryAmountInput, out pastryAmount))
      {
        if (pastryAmount > 0)
        {
        Pastry pastryOrder = new Pastry(pastryAmount);
        int pastryCost = pastryOrder.PastrySpecialCost();
        Console.WriteLine($"Alright, {pastryAmount} pastries will cost ya ${pastryCost}!");
        Console.WriteLine("Thanks, we'll see you soon!");
        Console.WriteLine(FiggleFonts.Shadow.Render("Have A Great Day!"));
        }
        else
        {
          Console.WriteLine("Please enter a positive number!");
          PastryOrder();
        }
      }
      else
      {
        Console.WriteLine("Sorry, we're looking for a numeric amount. Please try again!");
        Console.ReadLine();
        PastryOrder();
      }
    }

    public static void YouSaidNo()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Well, who needs ya, anyway? GO ON, GIT!");
        Console.ResetColor();
        Console.WriteLine("\n\n\n\n\n\n\n\n\n");
        Console.ReadLine();
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
        Console.ReadLine();
        Console.WriteLine("What do you think? Can we be friends again? Ya gonna buy some sweet sweet bread or some freakin' pastries? (Y/N)");
        string yOrN = (Console.ReadLine()).ToLower();
        if (yOrN == "y")
        {
          Console.WriteLine("Great! Let's start from the beginning, then!");
          Console.ReadLine();
          Main();
        }
        else
        {
          Console.WriteLine(FiggleFonts.Ogre.Render("I SAID, GIT!"));
        }
    }
    
  }
}