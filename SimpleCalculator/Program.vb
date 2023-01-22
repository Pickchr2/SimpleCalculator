'Christopher Pickens
'RCET0265
'Spring 2023
'Simple Calculator
'https://github.com/pickchr2/SimpleCalculator.git

Option Explicit On
Option Strict On

Imports System

Module Program
    Sub Main(args As String())
        Dim firstNumber As Integer
        Dim secondNumber As Integer

        Console.WriteLine("Please enter two whole numbers below that you wish to use for arithmetic...")
        Console.WriteLine("")
        AcceptFirstNumber(firstNumber)
        Console.WriteLine("Enter second number...")
        Console.WriteLine("")
        AcceptSecondNumber(secondNumber)
    End Sub

    Function AcceptFirstNumber(_firstNumber As Integer) As Integer
        Try
            _firstNumber = CInt(Console.ReadLine())
        Catch ex As Exception
            Console.WriteLine("Sorry, that is not a whole number.")
            AcceptFirstNumber(_firstNumber)
        End Try

        Return _firstNumber
    End Function

    Function AcceptSecondNumber(_secondNumber As Integer) As Integer
        Try
            _secondNumber = CInt(Console.ReadLine())
        Catch ex As Exception
            Console.WriteLine("Sorry, that is not a whole number.")
            AcceptFirstNumber(_secondNumber)
        End Try

        Return _secondNumber
    End Function
End Module
