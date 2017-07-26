Module Module1
 'If, ElseIf, and Else Structure
 Sub Main()
  Dim num1, num2 As Integer

  num1 = 1
  num2 = 2

  'if statement
  If num1 > num2 Then
   Console.WriteLine("First number is higher!")
  End If

  'if-else statement
  If num1 = num2 Then
   Console.WriteLine("They are equal!")
  Else
   Console.WriteLine("They are not equal!")
  End If

  'if-else if statement
  If num1 > num2 Then
   Console.WriteLine("First number is greater!")
  ElseIf num1 < num2 Then
   Console.WriteLine("Second number is greater!")
  End If

  Console.ReadKey()
 End Sub

End Module
