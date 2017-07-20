<pre><code>
Module Module1

 Sub Main()
  Dim num1 As Integer = 0
  Dim num2 As Integer = 0
  Dim num3 As Integer = 0
  Dim ave As Integer = 0

  Console.Write("Enter value of num1: ")
  num1 = Int32.Parse(Console.ReadLine())
  Console.Write("Enter value of num2: ")
  num2 = Int32.Parse(Console.ReadLine())
  Console.Write("Enter value of num3: ")
  num3 = Int32.Parse(Console.ReadLine())
  ave = (num1 + num2 + num3) / 3 

  Console.WriteLine("Average is " & ave)

  Console.ReadKey()
 End Sub

End Module

</code></pre>
