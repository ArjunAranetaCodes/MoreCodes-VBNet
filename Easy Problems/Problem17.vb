<pre><code>
Module Module1

 'Write a program that outputs the index of the first
 'occurrence of the letter in a string.

 Sub Main()
  Dim word As String = "program"
  Dim letter As String = "a"

  If word.Contains(letter) Then
   Console.WriteLine("Contains a")
  Else
   Console.WriteLine("Does Not Contain a")
  End If
  Console.ReadKey()
 End Sub

End Module

</code></pre>
