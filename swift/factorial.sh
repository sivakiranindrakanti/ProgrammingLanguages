print("Enter the number to know its factorial:", terminator : "")
var Count = Int(readLine()!)!
var Product = 1
var Counter = 1
while(Counter <= Count) {
  Product = Product * Counter
  Counter = Counter + 1
}
print("THe factorial of \(Count) is \(Product).")