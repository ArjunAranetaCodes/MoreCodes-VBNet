Module Module1

 'Problem 18: (Recursion) Write a program that outputs the
 'fibonacci sequence of a number.

 Sub Main()
  For x = 0 To 10
   Console.WriteLine(Fibonacci(x))
  Next
  Console.ReadKey()
 End Sub

 Function Fibonacci(ByVal num As Integer) As Integer
  If num = 1 Or num = 0 Then
   Return num
  Else
   Return Fibonacci(num - 1) + Fibonacci(num - 2)
 End If

 End Function

End Module
