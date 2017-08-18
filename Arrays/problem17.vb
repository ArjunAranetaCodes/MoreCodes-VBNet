
Module Module1

 Sub Main()
  Dim arrNumbers() As Integer = {1, 2, 3}

  For Each num As Integer In arrNumbers
   Console.WriteLine(num)
  Next

  Array.Resize(arrNumbers, arrNumbers.Length + 1)

  arrNumbers(3) = 10

  Console.WriteLine("New Array")
  For Each num As Integer In arrNumbers
   Console.WriteLine(num)
  Next

  Console.ReadKey()
 End Sub

End Module


