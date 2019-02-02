print("Enter the number to know it is prime or not:", terminator : "")
var Number = Int(readLine()!)!
var Counter = 2
while(Counter <= Number) {
  if(Counter * Counter > Number) {
    print("\(Number) is prime.")
    break;
  }
  else {
    if(Number % Counter == 0) {
      print("\(Number) is not a prime.")
      break;
    }
  }
  Counter = Counter + 1
}