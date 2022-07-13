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
      Player player1 = new Player(playerName);
      Player computer = new Player(comName);
      string resultPlayer = player1.PlayerName;
      string resultCom = computer.PlayerName;
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual(playerName, resultPlayer);
      Assert.AreEqual(comName, resultCom);
    }
  }
}

//[TestMethod]
//public void OutcomeElements_GetOutcome_Outcome()
//{
  //Outcome Rock = new Outcome(1);
  //Outcome Paper = new Outcome(2);
  //Outcome Scissors = new Outcome(3);
  //Assert.AreEqual(typeof(Outcome), Rock.GetType(), Paper.GetType(), Scissors.GetType());

//}