Module Module1

 'Problem 19: (Recursion) Write a program that outputs
 'all even numbers below 20.

 Sub Main()
  PrintEven(10)
  Console.ReadKey()
 End Sub

 Function PrintEven(ByVal num As Integer) As Integer
  If num = 0 Then
   Return num
  Else
  If num Mod 2 = 0 Then
   Console.WriteLine(num)
  End If
   Return PrintEven(num - 1)
  End If
 End Function

End Module
