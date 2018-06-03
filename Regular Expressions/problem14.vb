'Problem 14: Write a program that recognizes valid hex color value using Regular Expression.
Imports System.Text.RegularExpressions
Module Module1

    Sub Main()
        Dim pattern As String = "^([01]?\d\d?|2[0-4]\d|25[0-5])\.([01]?\d\d?|2[0-4]\d|25[0-5])\." &
                     "([01]?\d\d?|2[0-4]\d|25[0-5])\.([01]?\d\d?|2[0-4]\d|25[0-5])$"
        Console.WriteLine(Regex.IsMatch("192.168.1.1", pattern))
        Console.WriteLine(Regex.IsMatch("1.1.1.1.1", pattern))
        Console.ReadKey()
    End Sub

End Module
