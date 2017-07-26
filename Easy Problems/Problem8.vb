Module Module1

 'Problem 8: Write a program that outputs all numbers divisible by
 '5 from 1 to 30.

Sub Main()
 Dim sum As Integer

 For num As Integer = 1 To 30
  If num Mod 5 = 0 Then
   sum = sum + num
  End If
 Next

 Console.WriteLine("The sum of numbers divisible by 5 from 1 to 30 is " &
  sum)
 Console.ReadKey()
End Sub

End Module
