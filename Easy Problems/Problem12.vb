Module Module1

 'Problem 12: Write a program that asks a user for their
 'name and outputs a greeting with their name.

 Sub Main()
  Dim name As String

  Console.Write("Enter your name: ")
  name = Console.ReadLine()
  Console.WriteLine("Hello " & name)
  Console.ReadKey()
 End Sub

End Module
