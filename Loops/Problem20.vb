Module Module1

 'Problem 20: (RecursioN) Write a program that outputs the
 'sum of numbers from 1 to n.

 Sub Main()
  Console.WriteLine("Sum is " & GetSum(10, 0))
  Console.ReadKey()
 End Sub

 Function GetSum(ByVal num As Integer, ByVal sum As Integer) As Integer
  If num = 0 Then
   Return sum
  Else
   Return GetSum((num - 1), (sum + num))
  End If
 End Function

End Module
