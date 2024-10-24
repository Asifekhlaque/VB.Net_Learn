Imports System.Console

Module Program
    Sub Main(args As String())
        Dim num As Integer
        Console.WriteLine("Welcome To VB.net It's Time to Make A Simple Project On ODD & EVEN")
        Console.WriteLine("Enter a Number")
        num = Console.ReadLine()
        If num Mod 2 = 0 Then
            Console.WriteLine("The Number is Even")
        Else
            Console.WriteLine("The Number is Odd")
        End If
    End Sub
End Module
