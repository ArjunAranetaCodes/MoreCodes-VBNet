'Problem 10: Write a program that prints an integer with commas separator using Regular Expression.
Imports System.Text.RegularExpressions
Module Module1

    Sub Main()
        Dim word As String = "1000"
        Dim pattern As String = "(\d)(?=(\d{3})+$)"
        Console.WriteLine(Regex.Replace(word, pattern, "$1,"))
        Console.ReadKey()
    End Sub

End Module
