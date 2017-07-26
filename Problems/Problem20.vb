<pre><code>
Module Module1

 'Problem 20: Write a program that checks if a string is a
 'palindrome.

 Sub Main()
  Dim word As String = "anna"
  Dim tempWord As String = StrReverse(word)

  If word = tempWord Then
   Console.WriteLine("Palindrome")
  Else
   Console.WriteLine("Not Palindrome")
  End If
  Console.ReadKey()
 End Sub

End Module

</code></pre>
