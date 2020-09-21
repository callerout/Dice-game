using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("What is your name");              //Ask for the users name
    string name = Console.ReadLine();
    bool ans = true;
    int score = 0;                                         // makes ans equal to true so code run
    while (ans){
      Random rnd= new Random();                             // creates random number
      int dice = rnd.Next (1,7);
      Console.WriteLine (dice);
      score += dice;                                            //Creates the scoreboard

      if (dice == 6){
        Console.WriteLine ("You rolled a six your out");
        Console.WriteLine (name + " Your score is: " + score);
        break;                                                                //Output if get a six


      }
      Console.WriteLine (score);
      Console.WriteLine ("do you want to carry on y or n");            //Asks every round if want to continue
      string question = Console.ReadLine ();
      if (question == "n"){
        ans = false;                                                          //What happens if say no
        Console.WriteLine (name + " Your score is: " + score);

      }





    }

  }







}
