'Problem 14: Write a program to print the number pattern using loop.
'1
'22
'333
'4444
'55555
Module Module1

    Sub Main()
        Dim row As Integer = 5
        For y As Integer = 0 To row
            For x As Integer = 1 To y
                Console.Write(y)
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module
