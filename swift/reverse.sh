print("Enter the number to find reverse of it:", terminator : "")
var Count = Int(readLine()!)!
if(Count == 0) {
      print("The reverse of \(Count) is \(Count).")
}
var Counter = Count
print("The reverse of \(Count) is ", terminator : "")
while(Counter != 0) {
  Counter = Counter % 10
  print("\(Counter)", terminator : "")
  Count = Count / 10;
  Counter = Count;
}
print(".")