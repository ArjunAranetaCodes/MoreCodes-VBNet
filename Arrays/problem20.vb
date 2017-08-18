
Module Module1

 Sub Main()
  Dim arrNumbers() As Integer = {4, 2, 3, -1}
  Dim closest As Integer = 0
  Dim numDiff As Integer = arrNumbers.Max

  For Each num As Integer In arrNumbers
   Dim diff = 0 - num
   diff = Math.Abs(diff)
   If diff < numDiff Then
    numDiff = diff
    closest = num
   End If
  Next

  Console.WriteLine("Closest to zero is " & closest)
  Console.ReadKey()
 End Sub

End Module


