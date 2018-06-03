'Problem 15: Write a program that takes a value inside a <div> tag using Regular Expression.
Imports System.Text.RegularExpressions
Module Module1

    Sub Main()
        Dim word As String = "<div>Hello World</div>"
        Dim pattern As String = "<([^""]*""|'[^']*'|[^'"">])*>"
        Console.WriteLine(Regex.Replace(word, pattern, ""))
        Console.ReadKey()
    End Sub

End Module
