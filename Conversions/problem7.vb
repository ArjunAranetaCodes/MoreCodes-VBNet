'Problem 7: Write a program that converts a decimal number to binary number.
Module Module1

    Sub Main()
        Dim dec As Integer = 10
        Dim binary As String = ""

        Do While dec > 0
            binary = (dec Mod 2).ToString & binary
            dec = Math.Floor(dec / 2)
        Loop

        Console.WriteLine(binary)
        Console.ReadKey()
    End Sub

End Module