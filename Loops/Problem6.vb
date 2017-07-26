Module Module1

 'Problem 6: Write a program that outputs all odd numbers
 'below 20.

 Sub Main()
  For x As Integer = 0 To 20
   If x Mod 2 = 1 Then
    Console.WriteLine(x)
   End If
  Next
  Console.ReadKey()
 End Sub

End Module
