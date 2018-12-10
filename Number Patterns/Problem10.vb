'Problem 10: Write a program to print the number pattern using loop.
'12345
'23456
'34567
'45678
'56789
Module Module1

    Sub Main()
        Dim row As Integer = 5
        Dim col As Integer = 5
        Dim min As Integer = 1

        For y As Integer = 0 To row - 1
            Dim num As Integer = min + y
            For x As Integer = 0 To col - 1
                Console.Write(num)
                num = num + 1
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module
