

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
  }
}