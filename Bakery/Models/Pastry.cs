

namespace Bakery.Models
{
  public class Pastry
  {
    public int Price { get; set; }
    public int PurchaseAmount { get; set; }

    public Pastry(int price, int purchaseAmount)
    {
      Price = price;
      PurchaseAmount = purchaseAmount;
    }

    public int PastrySpecialDiscount(int userInput)
    {
      int discounted = 0;
      if (userInput % 3 == 0)
      {
        discounted = userInput / 3;
      }
      else
      {
        int extra = userInput % 3;
        discounted = (userInput - extra) / 3;
      }
      return discounted;
    }
  }
}