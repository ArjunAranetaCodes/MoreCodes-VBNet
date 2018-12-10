'Problem 8: Write a program to print the number pattern of ones and zeros using loop.
'11111
'11111
'11011
'11111
'11111
Module Module1

    Sub Main()
        Dim row As Integer = 5
        Dim col As Integer = 5
        For y As Integer = 0 To row - 1
            For x As Integer = 0 To col - 1
                If x = Math.Round(row / 2) And y = Math.Round(col / 2) Then
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
