'Problem 1: Write a program to print the number pattern of ones and zeros using loop.
'11111
'11111
'11111
'11111
'11111
Module Module1

    Sub Main()
        For y As Integer = 0 To 4
            For x As Integer = 0 To 4
                Console.Write("1")
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module
