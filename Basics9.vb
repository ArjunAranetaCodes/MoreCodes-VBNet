Module Module1

 Sub Main()
  function1()
  function2(5)
  Console.WriteLine("It's true! 1+1 = " & function3())
  Console.WriteLine("Hi " & function4("More", "Codes"))
  Console.ReadKey()
 End Sub

 'a sub in vbnet does not have a return value
 Sub function1()
  Console.WriteLine("Hello there!")
 End Sub

 'a sub in vbnet does not have a return value but can a have a passing argument/parameter
 Sub function2(ByVal num As Integer)
  Console.WriteLine("That number is " & num)
 End Sub

 'function that has return value but has no passing argument/parameter
 Function function3() As Integer
  Dim sum As Integer = 1 + 1
  Return sum
 End Function

 'function that has return value and has passing argument/parameter
 Function function4(ByVal firstName As String, ByVal lastName As String) As String
  Dim fullName As String = firstName & " " & lastName
  Return fullName
 End Function
End Module
