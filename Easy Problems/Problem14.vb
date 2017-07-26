<pre><code>
Module Module1

 'Problem 14: Write a program that replaces all letter
 ''a' in a string with letter 'e'

 Sub Main()
  Dim word As String = "program"
  Dim newWord As String = Replace(word, "a", "e")
  Console.WriteLine(newWord)
  Console.ReadKey()
 End Sub

End Module

</code></pre>
