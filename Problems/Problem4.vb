<pre><code>
Module Module1

 Sub Main()
  Dim radius As Integer = 0
  Dim PI As Double = 3.14
  Dim dia As Double = 0.0
  Dim area As Double = 0.0
  Dim cir As Double = 0.0

  Console.Write("Enter value of radius: ")
  radius = Convert.ToInt32(Console.ReadLine())

  dia = radius + radius
  area = PI * dia
  cir = 2 * PI * radius

  Console.WriteLine("Diameter of circle is " & dia)
  Console.WriteLine("Area of circle is " & area)
  Console.WriteLine("Circumference of circle is " & cir)
  Console.ReadKey()
 End Sub

End Module

</code></pre>
