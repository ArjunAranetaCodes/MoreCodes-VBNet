'Problem 16: Write a program that takes a value inside a <a> tag using Regular Expression.
Imports System.Text.RegularExpressions
Module Module1

    Sub Main()
        Dim word As String = "<a>Hello World</a>"
        Dim pattern As String = "<([^""]*""|'[^']*'|[^'"">])*>"
        Console.WriteLine(Regex.Replace(word, pattern, ""))
        Console.ReadKey()
    End Sub

End Module
