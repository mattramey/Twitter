using System;

class Twitter { //open class Twitter
  public static void Main (string[] args) {// open Main
    for(int i = 1; i <=4; i++){// open for loop
    Console.WriteLine ("Please enter what you want to Tweet. (140 characters max");
      Console.WriteLine();
    string tweet = Console.ReadLine();

    if(tweet.Length <=140){//open if
      Console.WriteLine();
      Console.WriteLine("Posted\n");
      Console.WriteLine("Test Passed\n");
    }// end if
      else{//open else
        Console.WriteLine();
        Console.WriteLine("Rejected\n");
        Console.WriteLine("Test Passed\n");
      }// end else
    }// end for
  }// end Main
}// end class