'Problem 20: Write a program that validates if string length is between 5 to 10 using Regular Expression.
Imports System.Text.RegularExpressions
Module Module1

    Sub Main()
        Dim pattern As String = "\w{5,10}\b"
        Console.WriteLine(Regex.IsMatch("Hello World", pattern))
        Console.WriteLine(Regex.IsMatch("Hi", pattern))
        Console.ReadKey()
    End Sub

End Module
