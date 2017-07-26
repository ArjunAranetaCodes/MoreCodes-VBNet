Module Module1

 'Problem 7: Write a program that finds the sum of all
 'numbers from 1 to 20.

 Sub Main()
  Dim sum As Integer

  For num As Integer = 1 To 20
   sum = sum + num
  Next

  Console.WriteLine("The sum of 1 to 20 is " & sum)
  Console.ReadKey()
 End Sub

End Module
