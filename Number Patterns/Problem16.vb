'Problem 16: Write a program to print the number pattern using loop.
'12345
'1234
'123
'12
'1
Module Module1

    Sub Main()
        Dim row As Integer = 4
        For y As Integer = row To 0 Step -1
            For x As Integer = 0 To y
                Console.Write(x + 1)
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module
