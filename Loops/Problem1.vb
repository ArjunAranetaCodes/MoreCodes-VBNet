Module Module1

 'Problem 1: Write a program that prints the numbers from 1 to 50.
 'Output "Fizz" for multiples of 3, output "Buzz" for multiples of 5, and
 'both "FizzBuzz" for multiples of both 3 and 5.'

 Sub Main()
  For x As Integer = 1 To 50
   If x Mod 3 = 0 And x Mod 5 = 0 Then
    Console.WriteLine("FizzBuzz")
   ElseIf x Mod 3 = 0 Then
    Console.WriteLine("Fizz")
   ElseIf x Mod 5 = 0 Then
    Console.WriteLine("Buzz")
   Else
    Console.WriteLine(x)
   End If
  Next
  Console.ReadKey()
 End Sub

End Module
