Imports System
Imports System.Console

Module Program
    Sub BMI(ByVal weight As Integer, ByVal height As Integer)
        Dim bmiOutPut As Integer
        bmiOutPut = weight / (height * height)
        WriteLine("You Weight is ")
        Write(weight)
        Write(" KG")

        WriteLine("You Height is ")
        Write(height)
        WriteLine(" M")

        WriteLine("You Bmi is ")
        Write(bmiOutPut)
        Write(" KG/m2")

    End Sub
    Sub Main(args As String())
        Dim w, h As Integer
        WriteLine("I am your Bmi Calculater")
        WriteLine("Enter Your Weight and Height")
        w = ReadLine()
        h = ReadLine()
        BMI(w, h)
    End Sub
End Module
