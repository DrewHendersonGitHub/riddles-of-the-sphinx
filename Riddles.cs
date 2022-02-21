using System;
using System.Collections.Generic;

class PingPong
{
  //public static Dictionary<string, string> riddles = new Dictionary<string, string>() {{"I am an odd number. Take away a letter and I become even. What number am I?", "Seven"}, {"What can fill a room but takes up no space?", "Light"}, {"What is 3/7 chicken, 2/3 cat and 2/4 goat?", "Chicago"}};

  
  static void Main()
  {
    List<string> questions = new List<string> {{"I am an odd number. Take away a letter and I become even. What number am I?"}, {"What can fill a room but takes up no space?"}, {"What is 3/7 chicken, 2/3 cat and 2/4 goat?"}};
    List<string> answers = new List<string> {{"Seven"}, {"Light"}, {"Chicago"}};

    
    int check = 0;
    while (questions.Count > 0)
    {
      Random rnd = new Random();
      int num  = rnd.Next(questions.Count);

      Console.WriteLine(questions[num]);
      string answer = Console.ReadLine();
      if (answer == answers[num])
      {
        Console.WriteLine("good job.");
        questions.Remove(questions[num]);
        answers.Remove(answers[num]);
      }
      else
      {
        Console.WriteLine("You are now being eaten idiot");
        check = 1;
        break;
      }
    }
    if (check == 0)
    {
      Console.WriteLine("u win");
    }
  }
}