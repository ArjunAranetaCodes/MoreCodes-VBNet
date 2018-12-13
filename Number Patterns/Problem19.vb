'Problem 19: Write a program to print the number pattern using loop.
'11 11
'11 11

'11 11
'11 11
Module Module1

    Sub Main()
        Dim row As Integer = 4
        Dim col As Integer = 4
        For y As Integer = 0 To row
            For x As Integer = 0 To col
                If Math.Round(col / 2) = x Or Math.Round(row / 2) = y Then
                    Console.Write(" ")
                ElseIf (col Mod 2 = 0 And Math.Round(col / 2) = x) Or (row Mod 2 = 0 And Math.Round(row / 2) = y) Then
                    Console.Write(" ")
                Else
                    Console.Write("1")
                End If
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module
