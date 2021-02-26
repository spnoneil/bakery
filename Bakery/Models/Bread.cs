

namespace Bakery.Models
{
  public class Bread
  {
    public int Price { get; set; }
    public int PurchaseAmount { get; set; }

    public Bread(int price, int purchaseAmount)
    {
      Price = price;
      PurchaseAmount = PurchaseAmount;
    }

    public int BreadSpecial(int userInput)
    {
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
      return discounted;
    }
  }
}