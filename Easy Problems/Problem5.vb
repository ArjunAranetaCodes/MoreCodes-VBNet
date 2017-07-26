<pre><code>
Module Module1

 'Problem 5: Write a program that accepts that accepts temperature in
 'Celcius and convert it to Farenheit.

 Sub Main()
  Dim celsius As Double = 0.0
  Dim farenheit As Double = 0.0

  Console.Write("Enter value of celsius: ")
  celsius = Convert.ToInt32(Console.ReadLine())
  farenheit = (9.0 / 5.0) * celsius + 32
  Console.WriteLine(celsius & "C equals to " & farenheit & "F")
  Console.ReadKey()
 End Sub

End Module

</code></pre>
