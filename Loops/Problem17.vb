Module Module1

 'Problem 17: Write a program that outputs the
 'fibonacci sequence of a number.

 Sub Main()
  Dim num1 As Integer
  Dim num2 As Integer
  num1 = 1
  num2 = 1

  Console.WriteLine(num1)

  While num2 < 100
   Console.WriteLine(num2)
   num2 = num2 + num1
   num1 = num2 - num1
  End While
  Console.ReadKey()
 End Sub

End Module
