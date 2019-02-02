using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Enter the number upto which you want to print the sum of even numbers:");
    int Count, Counter = 0, Sum = 0;
    Count = int.Parse(Console.ReadLine());
    for(Counter = 1; Counter <= Count; Counter++) {
      if(Counter % 2 == 0) {
        Sum = Sum + Counter;
      }
    }
    Console.Write(String.Format("The sum of first {0} even number is {1}.", Count, Sum));
  }
}