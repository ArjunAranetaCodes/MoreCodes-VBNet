
Module Module1

 Sub Main()
  Dim arrNumbers() As Integer = {1, 2, 3, 4}
  Array.Reverse(arrNumbers)

  For Each num As Integer In arrNumbers
   Console.WriteLine(num)
  Next
  Console.ReadKey()
 End Sub

End Module


