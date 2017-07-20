<pre><code>
Module Module1

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
