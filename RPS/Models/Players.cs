using System;

namespace RPS
{
  public class Player
  {
  public string Oouttcome {get; set;}
  public string PlayerName {get; set;}
  public Player(string playerName, string ooutcome) {
    PlayerName = playerName;
    Oouttcome = ooutcome;
  }
  //assign r, p , or s to player

  // static function
  // public class Outcom
    //public string Outcome(int decision) {
      // EachOutcome = Outcome();
      // int rock = 1;
      // int paper = 2;
      // int scissors = 3;
 /*      
      if (decision == 1) {
        return "rock";
      } 
      if (decision == 2) {
        return "paper";
      }
      if (decision == 3){
        return "scissors";
      }
      else {
        return "please pick an option!";
      }
    } */
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

  
    // properties, constructors, methods, etc. go here
  //   // public static string Player(string behavior)
  //   {
  //     return behavior + " is behaving";
  //   }
  }
}

