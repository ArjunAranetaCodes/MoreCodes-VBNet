<pre><code>
Module Module1

Sub Main()
 Dim num As Integer = 0
 Dim sum As Integer = 0
 Console.Write("Enter value of num: ")
 num = Int32.Parse(Console.ReadLine())

 For x As Integer = 1 To num
  sum = sum + x
 Next

 Console.WriteLine("The sum of 1 to " &
  num & " is " & sum)
 Console.ReadKey()
End Sub

End Module

</code></pre>
