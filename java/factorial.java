import java.util.Scanner;
class Main {
  public static void main(String[] args) {
    System.out.print("Enter the number to find its factorial:");
    int Count, Counter, Product = 1;
    Scanner ScannerObject =new Scanner(System.in);
    Count = ScannerObject.nextInt();
    for(Counter = 1; Counter <= Count; Counter++) {
      Product = Product * Counter;
    }
    System.out.format("The factorial of %d is %d.", Count, Product);
  }
}