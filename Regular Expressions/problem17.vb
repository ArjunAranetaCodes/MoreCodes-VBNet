'Problem 17: Write a program that removes the last word in a string using Regular Expression.
Imports System.Text.RegularExpressions
Module Module1

    Sub Main()
        Dim word As String = "Hello World"
        Dim pattern As String = "\w+$"
        Console.WriteLine(Regex.Replace(word, pattern, ""))
        Console.ReadKey()
    End Sub

End Module
