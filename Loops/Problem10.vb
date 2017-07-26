Module Module1

 'Problem 10: Write a program to check whether a given
 'number is an armstrong number or not.

 Sub Main()
  Dim num As Integer = 371
  Dim sum As Integer = 0
  Dim temp As Integer = 0
  Dim rmdr As Integer = 0

  temp = num

  While Not (temp = 0)
   rmdr = temp Mod 10
   sum = sum + (rmdr * rmdr * rmdr)
   temp = temp \ 10
  End While

  If (num = sum) Then
   Console.WriteLine("Armstrong number.")
  Else
   Console.WriteLine("Not an Armstrong number.")
  End If
  Console.ReadKey()
 End Sub

End Module
