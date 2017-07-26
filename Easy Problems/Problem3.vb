Module Module1

 'Problem 3: Write a program that accepts length and
 'width of rectangle to find area.

 Sub Main()
  Dim length As Integer = 0
  Dim width As Integer = 0
  Console.Write("Enter value of length: ")
  length = Int32.Parse(Console.ReadLine())
  Console.Write("Enter value of width: ")
  width = Int32.Parse(Console.ReadLine())
  Dim area As Integer = length * width

  Console.WriteLine("Area of Rectangle is " & area)
  Console.ReadKey()
 End Sub

End Module
