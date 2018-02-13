Module Module1

    Sub Main()
        Dim dec As Integer = 0
        Dim hex As String = "100"

        hex = StrReverse(hex)

        For x As Integer = 0 To hex.Length - 1
            dec = dec + (Integer.Parse(hex(x)) * Math.Pow(16, x))
        Next

        Console.WriteLine(dec)

        Console.ReadKey()
    End Sub

End Module