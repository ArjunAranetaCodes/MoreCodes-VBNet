'Problem 6: Write a program that removes white space and non-visible characters.
Imports System.Text.RegularExpressions
Module Module1

    Sub Main()
        Dim word As String = "Hello World"
        Dim pattern As String = "\s"
        Console.WriteLine(Regex.Replace(word, pattern, ""))
        Console.ReadKey()
    End Sub

End Module
