#include <stdio.h>

int main(void) {
  int Number1, Number2, Sum;
  printf("To add two numbers, enter the first number:");
  scanf("%d", &Number1);
  printf("Enter the second number:");
  scanf("%d", &Number2);
  Sum = Number1 + Number2;
  printf("The sum of %d and %d is ", Number1, Number2);
  printf("%d", Sum);
  printf(".");
  return 0;
}