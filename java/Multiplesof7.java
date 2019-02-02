import java.util.Scanner;
class Main {
  public static void main(String[] args) {
   int Count, Counter, Product;
   System.out.print("How many multiples of 7 do you want to print?");
   Scanner ScannerObject = new Scanner(System.in);
   Count = ScannerObject.nextInt();
   System.out.print("The first " + Count + " multiples of 7 are");
   for(Counter = 1; Counter <= Count; Counter++) {
     Product = 7 * Counter;
     System.out.print(" " + Product);
   }
   System.out.print(".");
  }
}