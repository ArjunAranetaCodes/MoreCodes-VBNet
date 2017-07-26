Module Module1

 'Problem 7: Write a program that outputs the sum of
 'numbers from 1 to n.

 Sub Main()
  Dim n As Integer = 10
  Dim sum As Integer = 0
  For x As Integer = 1 To n
   sum = sum + x
  Next
  Console.WriteLine("Sum is " & sum)
  Console.ReadKey()
 End Sub

End Module
