Module Module1

 'Problem 6: Write a program that checks a number
 'input is even or odd.

 Sub Main()
  Dim num As Integer = 0
  Console.Write("Enter value of num: ")
  num = Int32.Parse(Console.ReadLine())

  If num Mod 2 = 0 Then
   Console.WriteLine("Number is even")
  Else
   Console.WriteLine("Number is odd")
  End If

  Console.ReadKey()
 End Sub

End Module
