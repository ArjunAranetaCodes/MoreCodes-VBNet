
Module Module1

 Sub Main()
  Dim arrNumbers() As Integer = {1, 1, 2, 3}
  Dim count As Integer = 0


  For Each num As Integer In arrNumbers
   If num = 1 Then
    count = count + 1
   End If
  Next

  Console.WriteLine("Occurrence: " & count)
  Console.ReadKey()

 End Sub

End Module


