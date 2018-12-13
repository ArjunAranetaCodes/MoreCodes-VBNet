'Problem 17: Write a program to print the number pattern using loop.
'1
'12
'123
'1234
'12345
'1234
'123
'12
'1
Module Module1

    Sub Main()
        Dim row As Integer = 4
        For y As Integer = 0 To row
            For x As Integer = 0 To y
                Console.Write(x + 1)
            Next
            Console.WriteLine()
        Next

        For y As Integer = row - 1 To 0 Step -1
            For x As Integer = 0 To y
                Console.Write(x + 1)
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module
