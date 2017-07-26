Module Module1

 'Problem 13: Write a program that reverses a string.

 Sub Main()
  Dim word As String = "MoreCodes"
  Dim newWord As String = ""

  For x = Len(word) - 1 To 0 Step -1
   newWord = newWord & word.Substring(x, 1)
  Next
  Console.WriteLine(newWord)
  Console.ReadKey()
 End Sub

End Module
