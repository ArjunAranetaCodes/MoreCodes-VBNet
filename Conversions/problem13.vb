'Problem 13: Write a program that converts celsius to farenheit.
Module Module1

    Sub Main()
        Dim celsius As Double = 10.0
        Dim farenheit As Double = 0.0
        farenheit = (9.0 / 5.0) * celsius + 32
        Console.WriteLine(celsius & "C equals to " & farenheit & "F")
        Console.ReadKey()
    End Sub

End Module