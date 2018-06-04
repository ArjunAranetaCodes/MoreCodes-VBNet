'Problem 18: Write a program that extracts string inside quotation marks using Regular Expression.
Imports System.Text.RegularExpressions
Module Module1

    Sub Main()
        Dim word As String = "Hello 'World'"
        Dim pattern As String = "'([^""]*)'"
        Dim extract As String = Regex.Matches(word, pattern).Item(0).ToString
        Console.WriteLine(extract)
        Console.ReadKey()
    End Sub

End Module
