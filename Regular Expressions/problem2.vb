'Problem 2: Write a program that matches email address.
Imports System.Text.RegularExpressions
Module Module1

    Sub Main()
        Dim pattern As String = "^[_A-Za-z0-9-\+]+(\.[_A-Za-z0-9-]+)*@[A-Za-z0-9-]+(\.[A-Za-z0-9]+)*(\.[A-Za-z]{2,})$"
        Console.WriteLine(Regex.IsMatch("mark@yahoo.com", pattern))
        Console.WriteLine(Regex.IsMatch("mark-yahoo.com", pattern))
        Console.ReadKey()
    End Sub

End Module
