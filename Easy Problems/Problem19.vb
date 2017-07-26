<pre><code>
Module Module1

 'Problem 19: Write a program that counts the total number
 'of vowels in a string.

 Sub Main()
  Dim strVowels As String = "aeiou"
  Dim vowelCount As Integer = 0
  Dim word As String = "program"

  For i As Integer = 0 To Len(word) - 1
   If strVowels.Contains(word.Substring(i, 1)) Then
   vowelCount = vowelCount + 1
   End If
  Next
  Console.WriteLine("Total Vowels: " & vowelCount)
  Console.ReadKey()
 End Sub

End Module

</code></pre>
