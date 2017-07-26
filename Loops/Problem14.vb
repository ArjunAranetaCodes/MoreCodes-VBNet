Module Module1

 'Problem 14: Write a program that accepts 5 numbers
 'and outputs the average.

 Sub Main()
  Dim num As Integer = 0
  Dim sum As Integer = 0
  Dim ave As Integer = 0

  For x As Integer = 1 To 5
   Console.Write("Enter a number: ")
   num = Integer.Parse(Console.ReadLine())
   sum = sum + num
  Next
  ave = sum / 5
  Console.Write("Average is " & ave)
  Console.ReadKey()
 End Sub

End Module
