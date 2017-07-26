Module Module1

 'Problem 13: Write a program that outputs the length
 'of the string.

 Sub Main()
  Dim word As String = "MoreCodes"
  Dim strLength As Integer = Len(word)
  Console.WriteLine("String Length " & strLength.ToString())
  Console.ReadKey()
 End Sub

End Module
