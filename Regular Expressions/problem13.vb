'Problem 13: Write a program that recognizes valid hex color value using Regular Expression.
Imports System.Text.RegularExpressions
Module Module1

    Sub Main()
        Dim pattern As String = "^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$"
        Console.WriteLine(Regex.IsMatch("#fff", pattern))
        Console.WriteLine(Regex.IsMatch("#asdf", pattern))
        Console.ReadKey()
    End Sub

End Module
