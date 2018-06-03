'Problem 8: Write a program that checks if the String if valid url using Regular Expression.
Imports System.Text.RegularExpressions
Module Module1

    Sub Main()
        Dim pattern As String = "^(https?:\/\/)?(www\.)?([\w]+\.)+[‌​\w]{2,63}\/?$"
        Console.WriteLine(Regex.IsMatch("http://www.example.com", pattern))
        Console.WriteLine(Regex.IsMatch("wwwexamplecom", pattern))
        Console.ReadKey()
    End Sub

End Module
