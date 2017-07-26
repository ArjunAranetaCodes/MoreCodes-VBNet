Module Module1

 'Problem 18: Write a program that outputs the frequency of a
 'letter in a string.

 Sub Main()
  Dim strVowels As String = "a"
  Dim letterCount As Integer = 0
  Dim word As String = "program"

  For i As Integer = 0 To Len(word) - 1
   If strVowels.Contains(word.Substring(i, 1)) Then
    letterCount = letterCount + 1
   End If
  Next
  Console.WriteLine("Total: " & letterCount)
  Console.ReadKey()
 End Sub

End Module
