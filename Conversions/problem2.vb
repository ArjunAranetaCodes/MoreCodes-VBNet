'Problem 2: Write a program that converts a string to integer.
Module Module1

    Sub Main()
        Dim num1 As Integer = 0
        Dim num2 As Integer = 0
        Console.Write("Enter value of num1: ")
        num1 = Int32.Parse(Console.ReadLine())
        Console.Write("Enter value of num2: ")
        num2 = Int32.Parse(Console.ReadLine())
        Dim sum As Integer = num1 + num2
        Dim diff As Integer = num1 - num2
        Dim prod As Integer = num1 * num2
        Dim quot As Integer = num1 / num2

        Console.WriteLine("Sum is " & (sum))
        Console.WriteLine("Difference is " & (diff))
        Console.WriteLine("Product is " & (prod))
        Console.WriteLine("Quotient is " & (quot))
        Console.ReadKey()
    End Sub

End Module
