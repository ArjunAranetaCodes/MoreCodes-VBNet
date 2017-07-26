Module Module1

 'Problem 3: Write a program that count letters in a
 'string using a loop.

 Sub Main()
  Dim word As String = "MoreCodes"
  Dim count As Integer = 0

  For Each element As Char In word
   count = count + 1
  Next

  Console.WriteLine("String Length: " & count)
  Console.ReadKey()
 End Sub

End Module
