using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int Amount { get; set; }

    public Bread(int amount)
    {
      Amount = amount;
    }

    public int BreadSpecialCost(int userInput)
    {
    int cost = 0;
    int discounted = 0;
    if (userInput % 3 == 0)
    {
      discounted = userInput /3;
    }
    else
    {
      int extra = userInput % 3;
      discounted = (userInput - extra) / 3;
    }

    if (userInput < 2)
    {
      cost = userInput * 5;
    }
    else
    {
      cost = (userInput - discounted) * 5;
    }
    return cost;
    }
  }
}