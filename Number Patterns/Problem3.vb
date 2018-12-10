'Problem 3: Write a program to print the number pattern of ones and zeros using loop.
'01010
'01010
'01010
'01010
'01010
Module Module1

    Sub Main()
        For y As Integer = 0 To 4
            For x As Integer = 0 To 4
                If x Mod 2 = 0 Then
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
