using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesBreadClass_Bread()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetBreadOrder_ReturnBreadOrder_Int()
    {
      int breadTest = 5;
      Bread newBread = new Bread(5);
      int result = newBread.Amount;
      Assert.AreEqual(breadTest, result);
    }
    [TestMethod]
    public void BreadSpecialCost_ReturnRegularBreadCost_Int()
    {
      Bread newBread = new Bread(1);
      int result = newBread.BreadSpecialCost();
      Assert.AreEqual(5, result);
    }
    [TestMethod]
    public void BreadSpecialCost_ReturnsDiscountedBreadCost_Int()
    {
      Bread newBread = new Bread(5);
      int result = newBread.BreadSpecialCost();
      Assert.AreEqual(20, result);
    }
  }
}