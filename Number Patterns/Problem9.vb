﻿'Problem 9: Write a program to print the number pattern of ones and zeros using loop.
'11011
'11011
'00000
'11011
'11011
Module Module1

    Sub Main()
        Dim row As Integer = 5
        Dim col As Integer = 5
        For y As Integer = 0 To row - 1
            For x As Integer = 0 To col - 1
                If Math.Round(col / 2) = x Or Math.Round(row / 2) = y Then
                    Console.Write("0")
                ElseIf (col Mod 2 = 0 And Math.Round(col / 2) = x) Or (row Mod 2 = 0 And Math.Round(row / 2) = y) Then
                    Console.Write("0")
                Else
                    Console.Write("1")
                End If
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module
