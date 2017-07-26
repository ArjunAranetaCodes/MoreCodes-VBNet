<pre><code>
Module Module1

 'Problem 15: Write a program that finds if a string is
 'within a string.

 Sub Main()
  Dim word As String = "programming"
  Dim strSearch As String = "program"
  If word.Contains(strSearch) Then
   Console.WriteLine(strSearch & " Found")
  Else
   Console.WriteLine(strSearch & " Not Found")
  End If
  Console.ReadKey()
 End Sub

End Module

</code></pre>
