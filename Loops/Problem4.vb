Module Module1

 'Problem 4: Write a program that outputs an asterisk
 'pyramid.

 Sub Main()
  For y As Integer = 0 To 5
   For x As Integer = 0 To y
    Console.Write("*")
   Next
   Console.WriteLine()
  Next
  Console.ReadKey()
 End Sub

End Module
