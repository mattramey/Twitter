using System;

class Twitter { //open class Twitter
  public static void Main (string[] args) {// open Main
//Loop through the program 4 times to prompt the user 4 times.
    for(int i = 1; i <=4; i++){// open for loop
    Console.WriteLine ("Please enter what you want to Tweet. (140 characters max");
      Console.WriteLine();
// declare a variable to store the user's input.
    string tweet = Console.ReadLine();

  // creat an if-else to chech if the number of characters the user typed is less than or equal to 140. if <= computer will print "Posted" if >= the compter will print "Rejected"
    if(tweet.Length <=140){//open if
// print a space for better readability
      Console.WriteLine();
      Console.WriteLine("Posted\n");
      Console.WriteLine("Test Passed\n");
    }// end if
      else{//open else
// print a space for better readability
        Console.WriteLine();
        Console.WriteLine("Rejected\n");
        Console.WriteLine("Test Passed\n");
      }// end else
    }// end for
  }// end Main
}// end class