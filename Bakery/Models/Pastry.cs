namespace Bakery.Models
{
  public class Pastry
  {
    public int Amount { get; set; }

    public Pastry(int amount)
    {
      Amount = amount;
    }

    public int PastrySpecialCost(int userInput)
    {
      int cost;
      int discounted;
      if (userInput % 3 == 0)
      {
        discounted = userInput / 3;
      }
      else
      {
        int extra = userInput % 3;
        discounted = (userInput - extra) / 3;
      }

      if (userInput < 3)
      {
        cost = userInput * 2;
      }
      else
      {
        cost = ((userInput - discounted) *2) + discounted;
      }
      return cost;
    }
}
}