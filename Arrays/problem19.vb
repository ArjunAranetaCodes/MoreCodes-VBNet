
Module Module1

 Sub Main()
  Dim array1() As Integer = {1, 2, 3}
  Dim array2() As Integer = {1, 2, 3}
  Dim arr1Length = array1.Length
  Dim arr2Length = array2.Length

  Array.Resize(array1, arr1Length + arr2Length)

  Dim y As Integer = 0
  For x As Integer = arr1Length To array1.Length - 1
   array1(x) = array2(y)
   y = y + 1
  Next

  For Each num As Integer In array1
   Console.WriteLine(num)
  Next
  Console.ReadKey()
 End Sub

End Module


