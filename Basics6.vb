Module Module1
 'Loop Structures
 Sub Main()
 Console.WriteLine("For Loop")
 Dim x As Integer = 0
 For x = 0 To 10
  Console.Write(x)
 Next

 Console.WriteLine()
 Console.WriteLine()
 Console.WriteLine("While Loop")
 x = 0
 While x <= 10
  Console.Write(x)
  x += 1
 End While

 Console.WriteLine()
 Console.WriteLine()
 Console.WriteLine("Do Loop")
 x = 0
 Do
  Console.Write(x)
  x += 1
 Loop While x <= 10

 Console.WriteLine()
 Console.WriteLine()
 Console.WriteLine("Do-While Loop")
 x = 0
 Do While x <= 10
  Console.Write(x)
  x += 1
 Loop

 Console.WriteLine()
 Console.WriteLine()
 Console.WriteLine("Do-Until Loop")
 x = 0
 Do Until x = 11
  Console.Write(x)
  x += 1
 Loop

 Console.WriteLine()
 Console.WriteLine()
 Console.WriteLine("Do-Loop Loop")
 x = 0
 Do
  Console.Write(x)
  x += 1
 Loop Until x = 11

 Console.ReadKey()
End Sub

End Module
