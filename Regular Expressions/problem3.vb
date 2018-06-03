'Problem 3: Write a program that checks if string contains sample format date of (yyyy-mm-dd)
Imports System.Text.RegularExpressions
Module Module1

    Sub Main()
        Dim pattern As String = "([0-9]{4})-([0-9]{2})-([0-9]{2})"
        Console.WriteLine(Regex.IsMatch("2018-01-02", pattern))
        Console.WriteLine(Regex.IsMatch("01-01-02", pattern))
        Console.ReadKey()
    End Sub

End Module
