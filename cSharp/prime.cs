using System;

class MainClass {
  public static void Main (string[] args) {
      Console.Write("Enter the number to know it is prime or not:");
      int Count, Counter;
      Count = int.Parse(Console.ReadLine());
      for(Counter = 2; Counter <= Count; Counter++) {
        if(Counter * Counter > Count){
          Console.Write(String.Format("{0} is prime.", Count));
          break;
        }
        else {
          if(Count % Counter == 0) {
            Console.Write(String.Format("{0} is not a prime.", Count));
            break;
          }
        }
      }
  }
}