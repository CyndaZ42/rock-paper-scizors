using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS;

namespace RPS.Tests
{
  [TestClass]
  public class PlayersTests
  {
    // Test methods go here
    [TestMethod]
    public void MakePlayer_SetPlayer_ReturnValue()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual("Behavior is behaving", RPS.Method("Behavior"));
    }
  }
}