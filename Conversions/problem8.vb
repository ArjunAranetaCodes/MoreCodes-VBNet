'Problem 8: Write a program that converts a decimal number to hexadecimal number.
Module Module1

    Sub Main()
        Dim dec As Integer = 256
        Dim hex As String = ""

        Do While dec > 0
            hex = (dec Mod 16).ToString & hex
            dec = Math.Floor(dec / 16)
        Loop

        Console.WriteLine(hex)
        Console.ReadKey()
    End Sub

End Module