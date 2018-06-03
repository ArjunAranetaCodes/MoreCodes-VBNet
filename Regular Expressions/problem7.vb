'Problem 7: Write a program that counts vowels in a String using Regular Expression.
Imports System.Text.RegularExpressions
Module Module1

    Sub Main()
        Dim word As String = "Hello World"
        Dim pattern As String = "[^aeiouAEIOU]"
        Dim count As Integer = Regex.Replace(word, pattern, "").Count
        Console.WriteLine(count)
        Console.ReadKey()
    End Sub

End Module
