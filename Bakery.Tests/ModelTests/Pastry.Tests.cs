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
    public void GetPastryOrder_ReturnPastryOrder_Int()
    {
      int pastryTest = 5;
      Pastry newPastry = new Pastry(5);
      int result = newPastry.Amount;
      Assert.AreEqual(pastryTest, result);
    }
    [TestMethod]
    public void PastrySpecialCost_ReturnRegularPastryCost_Int()
    {
      Pastry newPastry = new Pastry(1);
      int result = newPastry.PastrySpecialCost();
      Assert.AreEqual(2, result);
    }
    [TestMethod]
    public void PastrySpecial_ReturnsDiscountedPastryCost_Int()
    {
      Pastry newPastry = new Pastry(4);
      int result = newPastry.PastrySpecialCost();
      Assert.AreEqual(7, result);
    }
  }
}