﻿'Problem 11: Write a program to print the pattern of asterisks using loop.
'*
'**
'***
'****
'*****
Module Module1

    Sub Main()
        Dim row As Integer = 4
        For y As Integer = 0 To row
            For x As Integer = 0 To y
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module
