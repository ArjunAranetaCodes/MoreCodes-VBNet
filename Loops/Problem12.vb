Module Module1

 'Problem 12: Calculate the Product of two numbers
 'WITHOUT using the * operator.

Sub Main()
 Dim num1 As Integer = 3
 Dim num2 As Integer = 5
 Dim prod As Integer = 0

 For x = 1 To 5
  prod = prod + num1
 Next
 Console.WriteLine("3 * 5 = " & prod)
 Console.ReadKey()
End Sub

End Module
