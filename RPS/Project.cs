using System;

 namespace RPS {
   public class Program
   {
     public static void Main()
     {
      Console.WriteLine("Enter an Option!");
      // Console.Write(Ooutcome.rock);
      Console.WriteLine("1.Rock");
      Console.WriteLine("2.Paper");
      Console.WriteLine("3.Scissors");

      string userChoice = Console.ReadLine();

      if (userChoice == "1")
      {
        Console.WriteLine("You Win!");
        Console.WriteLine("Computer Wins!");
        Console.WriteLine("You Tied!");
      }
      else if (userChoice == "2")
      {
        Console.WriteLine("You Win!");
        Console.WriteLine("Computer Wins!");
        Console.WriteLine("You Tied!");
      }
      else if (userChoice == "3")
      {
        Console.WriteLine("You Win!");
        Console.WriteLine("Computer Wins!");
        Console.WriteLine("You Tied!");
      }
      Random rnd = new Random();
      Console.WriteLine(rnd.Next(2)+1);
     }
     public static void Entry()
     {
      string Input = Console.ReadLine();

      // if (player1 == "rock" && computer == "Scissors")
     }
   }
 }

 // Outcome rock = new Outcome(1);
 //Outcome

 /*
 Random rnd = new Random();

 Console.WriteLine(rnd.Next(3));  //returns random integers < 3
*/