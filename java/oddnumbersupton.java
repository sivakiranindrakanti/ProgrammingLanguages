import java.util.Scanner;
class Main {
  public static void main(String[] args) {
    int Count, Counter;
    System.out.print("Enter the number upto which you want to print the odd numbers:");
    Scanner ScannerObject = new Scanner(System.in);
    Count = ScannerObject.nextInt();
    System.out.print("Odd numbers upto " + Count + " are");
    for(Counter = 0; Counter <= Count; Counter++) {
      if(Counter % 2 == 1) {
        System.out.print(" " + Counter);
      }
    }
    System.out.print(".");
  }
}