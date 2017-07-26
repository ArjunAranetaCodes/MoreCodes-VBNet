<pre><code>
Module Module1

 'Problem 1: Write a program that accepts
 'two numbers and find the sum.

 Sub Main()
  Dim num1 As Integer = 0
  Dim num2 As Integer = 0
  Console.Write("Enter value of num1: ")
  num1 = Int32.Parse(Console.ReadLine())
  Console.Write("Enter value of num2: ")
  num2 = Int32.Parse(Console.ReadLine())
  Dim sum As Integer = num1 + num2

  Console.WriteLine("Sum is " & (sum))
  Console.ReadKey()
 End Sub

End Module

</code></pre>
