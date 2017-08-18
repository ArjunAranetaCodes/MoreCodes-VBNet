
Module Module1

 Sub Main()
  Dim array1() As Integer = {1, 2, 3}
  Dim array2() As Integer

  array2 = array1
  For Each num As Integer In array2
   Console.WriteLine(num)
  Next
  Console.ReadKey()
 End Sub

End Module


