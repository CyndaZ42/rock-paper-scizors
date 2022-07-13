using System;

namespace RPS
{
  public class Player
  {
  public string PlayerName {get; set;}
  public Player(string playerName) {
    PlayerName = playerName;
  }
  //assign r, p , or s to player

  // static function
  // public class Outcom
    // public int EachOutcome {get;set;}
    public string Outcome(int decision) {
      // EachOutcome = Outcome();
      int rock =1;
      int paper = 2;
      int scissors = 3;
      
      if (decision == r1) {
        return "rock";
      } 
      if (decsion == 2) {
        return "paper";
      }
      if (decision == 3){
        return "scissors";
      }
      else {
        return "please pick an option!"
      }
//public string Outcome(int decision) {
//       if ( decion == 1) {
//       return "rock";
//       } 
//       if (decision == 2) {
//         return "paper";
//       }
//       if (decision == 3){
//         return "scissors";
//       }
// }

  }
    // properties, constructors, methods, etc. go here
  //   // public static string Player(string behavior)
  //   {
  //     return behavior + " is behaving";
  //   }
  }
}

