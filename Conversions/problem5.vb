'Problem 5: Write a program that converts an array/list to string.
Module Module1

 Sub Main()
  Dim arrNumbers() As String = {"1", "2", "3"}
  Dim numbers As String = String.Join("", arrNumbers)

  Console.WriteLine(numbers)
  Console.ReadKey()
 End Sub

End Module
