'Problem 9: Write a program that checks if the string is alphanumeric using Regular Expression.
Imports System.Text.RegularExpressions
Module Module1

    Sub Main()
        Dim pattern As String = "(([A-Z].*[0-9])|([0-9].*[A-Z]))"
        Console.WriteLine(Regex.IsMatch("HelloWorld", pattern))
        Console.WriteLine(Regex.IsMatch("HelloWorld123", pattern))
        Console.ReadKey()
    End Sub

End Module
