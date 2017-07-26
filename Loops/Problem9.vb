Module Module1

 'Problem 9: Write a program to display the multiplication
 'table of a given integer.

 Sub Main()
  Dim num As Integer = 2

  For x As Integer = 1 To 10
   Console.WriteLine(num & " x " & x &
    " = " & (num * x))
  Next
  Console.ReadKey()
 End Sub

End Module
