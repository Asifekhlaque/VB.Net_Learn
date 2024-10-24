Imports System.Console

Module Program
    Sub Main(args As String())
     Dim i As Integer
     Dim num As Integer
     Dim fact As Integer
     fact = 1
     Console.WriteLine("This The Program which give you Factorial of a number")
     num = Console.ReadLine()
     For i = 1 To num
      fact = fact * i
     Next
     Console.WriteLine(fact)
    End Sub
End Module
