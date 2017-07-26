Module Module1
 'Variables and Input
 Sub Main()
  Dim name As String
  Dim sex As Char
  Dim age As Integer

  Console.Write("What is your name? ")
  name = Console.ReadLine()
  Console.Write("What is your sex? ")
  sex = Char.Parse(Console.ReadLine())
  Console.Write("What is your age? ")
  age = Int32.Parse(Console.ReadLine())

  Console.WriteLine()
  Console.WriteLine("Name: " & name)
  Console.WriteLine("Sex: " & sex)
  Console.WriteLine("Age: " & age)
  Console.ReadKey()
 End Sub
End Module
