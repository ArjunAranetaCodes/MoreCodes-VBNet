'Problem 4: Write a program that converts a string to array/list.'
Module Module1

    Sub Main()
        Dim numbers As String = "1,2,3"
        Dim arrNumbers() As String = numbers.Split(",")

        For Each num In arrNumbers
            Console.WriteLine(num)
        Next
        Console.ReadKey()
    End Sub

End Module
