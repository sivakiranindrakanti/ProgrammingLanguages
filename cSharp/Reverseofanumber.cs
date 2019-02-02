using System;

class MainClass {
  public static void Main (string[] args) {
      Console.Write("Enter the number to find its reverse:");
      int Count, Counter;
      Count = int.Parse(Console.ReadLine());
      Console.Write(String.Format("The reverse of {0} is ", Count));
      Counter = Count;
      if(Counter == 0) {
        Console.Write(String.Format("{0}.", Counter));
      }
      while(Counter != 0) {
        Console.Write(String.Format("{0}", Counter = Counter % 10));
        Count = Count / 10;
        Counter = Count;
      }
      Console.Write(".");    
  }
}