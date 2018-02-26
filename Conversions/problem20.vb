'Problem 20: Write a program that converts a number to its 
'corresponding month (e.g. 1 = January).
Module Module1

    Sub Main()
        Dim word As String = "anna"
        Dim tempWord As String = StrReverse(word)

        If word = tempWord Then
            Console.WriteLine("Palindrome")
        Else
            Console.WriteLine("Not Palindrome")
        End If
        Console.ReadKey()
    End Sub

End Module
