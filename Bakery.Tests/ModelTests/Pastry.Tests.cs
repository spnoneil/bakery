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
  }
}