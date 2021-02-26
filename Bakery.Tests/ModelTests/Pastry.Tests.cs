using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Test
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesPastryClass_Pastry()
    {
      Pastry newPastry = new Pastry(4, 5);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void PastrySpecial_ReturnsDiscountedPastryAmount_Int()
    {
      Pastry newPastry = new Pastry(4, 5);
      int result = newPastry.PastrySpecialDiscount(20);
      Assert.AreEqual(6, result);
    }
  }
}