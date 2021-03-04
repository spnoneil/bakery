namespace Bakery.Models
{
  public class Pastry
  {
    public int Amount { get; private set; }

    public Pastry(int amount)
    {
      Amount = amount;
    }

    public int PastrySpecialCost()
    {
      int cost;
      int discounted;
      if (Amount % 3 == 0)
      {
        discounted = Amount / 3;
      }
      else
      {
        int extra = Amount % 3;
        discounted = (Amount - extra) / 3;
      }

      if (Amount < 3)
      {
        cost = Amount * 2;
      }
      else
      {
        cost = ((Amount - discounted) *2) + discounted;
      }
      return cost;
    }
}
}