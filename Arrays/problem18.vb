
Module Module1

 Sub Main()
  Dim arrNumbers() As Integer = {1, 3, 2, 4}
  Array.Sort(arrNumbers)
  Array.Reverse(arrNumbers)

  For Each num As Integer In arrNumbers
   Console.WriteLine(num)
  Next
  Console.ReadKey()
 End Sub

End Module


