#include <stdio.h>

int main(void) {
  int Number1, Number2, Number3, Product;
  printf("To multiply three numbers, enter the first number:");
  scanf("%d", &Number1);
  printf("Enter the second number:");
  scanf("%d", &Number2);
  printf("Enter the third number:");
  scanf("%d", &Number3);
  printf("The product of %d, %d and %d is ", Number1, Number2, Number3);
  Product = Number1 * Number2 * Number3;
  printf("%d", Product);
  printf(".");
  return 0;
}