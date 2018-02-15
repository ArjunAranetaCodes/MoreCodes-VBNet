'Problem 10: Write a program that converts a decimal number to octal number.
Module Module1

    Sub Main()
        Dim dec As Integer = 256
        Dim oct As String = ""

        Do While dec > 0
            oct = (dec Mod 8).ToString & oct
            dec = Math.Floor(dec / 8)
        Loop

        Console.WriteLine(oct)
        Console.ReadKey()
    End Sub

End Module
