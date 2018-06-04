'Problem 19: Write a program that counts all numbers in a string using Regular Expression.
Imports System.Text.RegularExpressions
Module Module1

    Sub Main()
        Dim word As String = "Hello World123"
        Dim pattern As String = "[^0-9]"
        Dim count As Integer = Regex.Replace(word, pattern, "").Count
        Console.WriteLine(count)
        Console.ReadKey()
    End Sub

End Module
