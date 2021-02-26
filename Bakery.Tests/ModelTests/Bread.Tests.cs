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
      Bread newBread = new Bread(5, 6);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    
  }
}