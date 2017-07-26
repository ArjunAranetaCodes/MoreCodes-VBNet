Module Module1
 'Switch Statement'
 Sub Main()
  Dim num1 As Integer = 10

  Select Case num1
   Case 1
    Console.WriteLine("Seems it is number 1")
   Case 5, 10
    Console.WriteLine("Feels like it is five or 10")
  End Select

  Console.ReadKey()
 End Sub

End Module
