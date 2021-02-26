

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
  }
}