using System;

class MainClass {
  public static void Main (string[] args) {
    int Count, Counter, Sum = 0;
    Console.Write("How many natural numbers do you want to add?");
    Count = int.Parse(Console.ReadLine());
    for(Counter = 1; Counter <= Count; Counter++) {
      Sum = Sum + Counter;
    }
    Console.Write("The sum of first " + Count + " natural numbers is " + Sum + ".");
  }
}