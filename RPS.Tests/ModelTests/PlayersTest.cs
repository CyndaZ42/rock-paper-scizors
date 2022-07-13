using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS;

namespace RPS.Tests
{
  [TestClass]
  public class PlayerTests
  {
    // Test methods go here
    [TestMethod]
    public void GetPlayer_SetPlayerVal_Player()
    {
      string playerName = "player1";
      string comName = "Computer";
      Player player1 = new Player(playerName, playerName);
      Player computer = new Player(comName, comName);
      string resultPlayer = player1.PlayerName;
      string resultCom = computer.PlayerName;
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual(playerName, resultPlayer);
      Assert.AreEqual(comName, resultCom);
    }
  }
}

[TestMethod]
public void OutcomeElements_GetOutcome_Oouttcome()
{
  string playerName = "player1";
  Player player1 = new Player(playerName, "rock");
  //player1.Outcome = "rock";
  //Outcome decision = new Outcome(1);
  //Outcome paper = new Outcome(2);
  //Outcome scissors = new Outcome(3);
  Assert.AreEqual(typeof(Player), player1.Oouttcome.GetType());

}

// [TestMethod]
// public void 