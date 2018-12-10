'Problem 7: Write a program to print the number pattern of ones and zeros using loop.
'10101
'01010
'10101
'01010
'10101
Module Module1

    Sub Main()
        Dim count As Integer = 0
        For y As Integer = 0 To 4
            For x As Integer = 0 To 4
                count = count + 1
                If count Mod 2 = 1 Then
                    Console.Write("1")
                Else
                    Console.Write("0")
                End If
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module
