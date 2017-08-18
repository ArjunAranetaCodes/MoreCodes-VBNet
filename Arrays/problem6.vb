
Module Module1

 Sub Main()
  Dim arrNumbers() As Integer = {1, 2, 3}

  If arrNumbers.Contains(2) Then
   Console.WriteLine("Contains 2")
  Else
   Console.WriteLine("Does not contains 2")
  End If
  Console.ReadKey()
 End Sub

End Module


