
Module Module1

 Sub Main()
  Dim arrNumbers() As Integer = {1, 2, 3, 4}
  Dim n = 2
  Dim tempNum = 0
  Dim indexOfNum = Array.IndexOf(arrNumbers, n)

  For i As Integer = 0 To arrNumbers.Length - 1
   If i >= indexOfNum And i < arrNumbers.Length - 1 Then
    arrNumbers(i) = arrNumbers(i + 1)
   End If
  Next
  Array.Resize(arrNumbers, arrNumbers.Length - 1)

  For Each num As Integer In arrNumbers
  Console.WriteLine(num)
  Next

  Console.ReadKey()
 End Sub

End Module


