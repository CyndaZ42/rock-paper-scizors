using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS;

namespace RPS.Tests
{
  [TestClass]
  public class PlayersTests
  {
    // Test methods go here
    [TestMethod]
    public void GetPlayer_SetPlayerVal_Player()
    {
      Player Player1 = new Player("playerName");
      Player Computer = new Player("Computer");
 
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual(typeof(Player), Player1.GetType(), Computer.GetType());
    }
  }
}

//[TestMethod]
//public void OutcomeC 