'Problem 12: Write a program that counts the occurrence of digits in a string using Regular Expression.
Imports System.Text.RegularExpressions
Module Module1

    Sub Main()
        Dim word As String = "Hello12 World12"
        Dim pattern As String = "\D"
        Console.WriteLine(Regex.Replace(word, pattern, "").Count)
        Console.ReadKey()
    End Sub

End Module
