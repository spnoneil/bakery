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
      Pastry newPastry = new Pastry(4);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void PastrySpecial_ReturnsDiscountedPastryCost_Int()
    {
      Pastry newPastry = new Pastry(4);
      int result = newPastry.PastrySpecialCost(10);
      Assert.AreEqual(17, result);
    }
  }
}