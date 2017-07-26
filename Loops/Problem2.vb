Module Module1

 'Problem 2: Write a program that outputs 5 random integers.

 Sub Main()
  Dim rand As Random = New Random

  For x As Integer = 0 To 4
   Console.Write(rand.Next(1, 9))
  Next
  Console.ReadKey()
 End Sub

End Module
