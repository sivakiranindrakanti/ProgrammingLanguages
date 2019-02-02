import java.util.Scanner;

class Main {

  public static void main(String[] args) {

    System.out.print("Enter the number to find its reverse:");

    int Count, Counter;

    Scanner ScannerObject = new Scanner(System.in);

    Count = ScannerObject.nextInt();

    System.out.format("The reverse of %d is ", Count);

    Counter = Count;

    if(Counter == 0) {

      System.out.format("%d.",Counter);

    }

    while(Counter != 0) {

      System.out.format("%d", Counter = Counter % 10);

      Count = Count / 10;

      Counter = Count;

    }

    System.out.print(".");

  }

}