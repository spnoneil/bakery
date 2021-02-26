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
    public void BreadSpecialCost_ReturnsDiscountedBreadCost_Int()
    {
      Bread newBread = new Bread(5);
      int result = newBread.BreadSpecialCost(7);
      Assert.AreEqual(25, result);
    }

  }
}