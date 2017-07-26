Module Module1

 'Problem 16: Write a program that outputs the factorial
 'of a number.

 Sub Main()
  Dim num As Integer = 5
  Dim fact As Integer = 1

  For x = num To 1 Step -1
   fact = fact * x
  Next
  Console.WriteLine("Factorial of 5 is " & fact)
  Console.ReadKey()
 End Sub

End Module
