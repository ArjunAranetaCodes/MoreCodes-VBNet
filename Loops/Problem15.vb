Module Module1

 'Problem 15: Write a program that will ask the user to
 'input n positive numbers. The program will terminate
 'if one of those number is not positive.

 Sub Main()
  Dim num As Integer = 0

  While num > -1
   Console.Write("Enter a number: ")
   num = Integer.Parse(Console.ReadLine())
  End While
  Console.Write("Terminated.")
  Console.ReadKey()

 End Sub

End Module
