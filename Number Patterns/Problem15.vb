'Problem 15: Write a program to print the number pattern using loop.
'11111
'2222
'333
'44
'5
Module Module1

    Sub Main()
        Dim row As Integer = 4
        Dim num As Integer = 1
        For y As Integer = row To 0 Step -1
            For x As Integer = 0 To y
                Console.Write(num)
            Next
            num = num + 1
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module
