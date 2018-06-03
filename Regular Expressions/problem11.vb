'Problem 11: Write a program that counts the occurrence of a string in a string using Regular Expression.
Imports System.Text.RegularExpressions
Module Module1

    Sub Main()
        Dim word As String = "HelloWorldHelloWorld"
        Dim pattern As String = "Hello"
        Dim count As Integer = Regex.Matches(word, pattern).Count
        Console.WriteLine(count)
        Console.ReadKey()
    End Sub

End Module
