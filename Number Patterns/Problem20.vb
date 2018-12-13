'Problem 20: Write a program to print the number pattern using loop.
'  1
' 222
'33333
' 444
'  5
Module Module1

    Sub Main()
        Dim rows As Integer = 3
        Dim stars As Integer = 1
        Dim blank As Integer = rows - 1

        For y As Integer = 1 To rows * 2
            For x As Integer = 1 To blank
                Console.Write(" ")
            Next

            For x As Integer = 1 To (stars * 2) - 1
                Console.Write(y)
            Next

            Console.WriteLine()

            If y < rows Then
                blank = blank - 1
                stars = stars + 1
            Else
                blank = blank + 1
                stars = stars - 1
            End If
        Next
        Console.ReadKey()
    End Sub

End Module
