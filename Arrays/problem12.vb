
Module Module1

 Sub Main()
  Dim array1() As Integer = {1, 2, 3}
  Dim array2() As Integer = {1, 2, 3, 4}

  If array1.SequenceEqual(array2) Then
   Console.WriteLine("Equal Arrays")
  Else
   Console.WriteLine("Not Equal")
  End If
  Console.ReadKey()
 End Sub

End Module


