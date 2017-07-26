Module Module1

 'Problem 11: Write a program that checks if a number
 'is palindrome.

 Sub Main()
  Dim num As Integer = 33433
  Dim sum As Integer = 0
  Dim temp As Integer = 0
  Dim rmdr As Integer = 0

  temp = num

  While Not (temp = 0)
   rmdr = temp Mod 10
   sum = sum * 10 + rmdr
   temp = temp \ 10
  End While

  If (num = sum) Then
   Console.WriteLine("Palindrome number.")
  Else
   Console.WriteLine("Not a Palindrome number.")
  End If
  Console.ReadKey()
 End Sub

End Module
