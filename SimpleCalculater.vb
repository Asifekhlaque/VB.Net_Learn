Imports System.Console

Module Program
    Sub Main(args As String())
        Dim num1, num2 As Integer
        Dim symbol As String
        WriteLine("Welcome to simple calculater")
        WriteLine("Enter two number")
        num1 = ReadLine()
        num2 = ReadLine()
        WriteLine("Enter the symbole +, -, *, /")
        symbol = ReadLine()
        Select Case symbol
            Case "+"
                WriteLine("Sum =" & num1 + num2)
            Case "-"
                WriteLine("Sub =" & num1 - num2)
            Case "*"
                WriteLine("Mult =" & num1 * num2)
            Case "/"
                WriteLine("Div =" & num1 / num2)
            Case Else
                WriteLine("Invalid Input")
        End Select
    End Sub
End Module
