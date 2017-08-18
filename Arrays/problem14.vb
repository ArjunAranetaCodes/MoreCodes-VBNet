
Module Module1

 Sub Main()
  Dim arrNumbers() As Integer = {1, 2, 3, 4}

  For Each num As Integer In arrNumbers
   If num Mod 2 = 1 Then
    Console.WriteLine(num)
   End If
  Next
  Console.ReadKey()
 End Sub

End Module


