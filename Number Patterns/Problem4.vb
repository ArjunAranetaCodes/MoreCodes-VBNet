'Problem 4: Write a program to print the number pattern of ones and zeros using loop.
'10001
'10001
'10001
'10001
'10001
Module Module1

    Sub Main()
        For y As Integer = 0 To 4
            For x As Integer = 0 To 4
                If (x = 0) Or (x = 4) Then
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
