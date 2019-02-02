#include <stdio.h>

int main(void) {
  printf("Enter the number to know it is prime or not:");
  int Count;
  scanf("%d", &Count);
  int Counter = 2;
  for(Counter = 2; Counter <= Count; Counter++){
    if(Counter * Counter > Count) {
      printf("%d is prime.", Count);
      break;
    }
    else {
      if(Count % Counter == 0) {
         printf("%d is not a prime.", Count);
         break;
        }
    }
  }
  return 0;
}