using System;

class MainClass {
  public static void Main (string[] args) {
    int Count, Counter;
    Console.Write("Which multiplication table do you want to print:");
    Count = int.Parse(Console.ReadLine());
    Console.WriteLine("Multiplication table for " + Count);
    for(Counter = 1; Counter <= 10; Counter++) {
      Console.WriteLine(String.Format("{0,0}  x {1,3} = {2,5}", Count, Counter, Count * Counter));
    }
  }
}