'Problem 5: Write a program that matches time in 24 hour format.
Imports System.Text.RegularExpressions
Module Module1

    Sub Main()
        Dim pattern As String = "^(0?[1-9]|1[012])(:[0-5]\d) [APap][mM]$"
        Console.WriteLine(Regex.IsMatch("25:00 am", pattern))
        Console.WriteLine(Regex.IsMatch("08:01 am", pattern))
        Console.ReadKey()
    End Sub

End Module
