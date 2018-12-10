'Problem 6: Write a program to print the number pattern of ones and zeros using loop.
'11111
'10001
'10001
'10001
'11111
Module Module1

    Sub Main()
        For y As Integer = 0 To 4
            For x As Integer = 0 To 4
                If (y = 0) Or (y = 4) Or (x = 0) Or (x = 4) Then
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
