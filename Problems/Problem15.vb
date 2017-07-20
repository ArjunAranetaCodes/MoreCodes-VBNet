<pre><code>
Module Module1

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
