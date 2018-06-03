'Problem 1: Write a program to test if the first character of the String is uppercase.
Imports System.Text.RegularExpressions
Module Module1

    Sub Main()
        Dim pattern As String = "^[A-Z][a-z0-9_-]{3,19}$"
        Console.WriteLine(Regex.IsMatch("Hello", pattern))
        Console.WriteLine(Regex.IsMatch("world", pattern))
        Console.ReadKey()
    End Sub

End Module
