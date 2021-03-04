namespace Bakery.Models
{
  public class Bread
  {
    public int Amount { get; private set; }

    public Bread(int amount)
    {
      Amount = amount;
    }

    public int BreadSpecialCost()
    {
    int cost;
    int discounted;
    if (Amount % 3 == 0)
    {
      discounted = Amount /3;
    }
    else
    {
      int extra = Amount % 3;
      discounted = (Amount - extra) / 3;
    }

    if (Amount < 2)
    {
      cost = Amount * 5;
    }
    else
    {
      cost = (Amount - discounted) * 5;
    }
    return cost;
    }
  }
}