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
        Dim desiredOperation As String = ""
        Dim mathResult As Integer

        Console.WriteLine("Please enter two whole numbers below that you wish to use for arithmetic...")
        firstNumber = AcceptFirstNumber(firstNumber)
        Console.WriteLine("")
        Console.WriteLine("Enter second number...")
        secondNumber = AcceptSecondNumber(secondNumber)
        Console.WriteLine("")
        Console.WriteLine("Please select your desired operation, enter 1 for + or enter 2 for *")
        desiredOperation = AcceptDesiredOperation(desiredOperation)

        If desiredOperation = "1" Then
            desiredOperation = "sum"
            mathResult = firstNumber + secondNumber
        ElseIf desiredOperation = "2" Then
            desiredOperation = "product"
            mathResult = firstNumber * secondNumber
        End If

        Console.WriteLine("")
        Console.WriteLine("The " & desiredOperation & " of " & firstNumber & " and " & secondNumber & " is " & mathResult)
    End Sub

    Function AcceptFirstNumber(_firstNumber As Integer) As Integer
        Try
            _firstNumber = CInt(Console.ReadLine())
        Catch ex As Exception
            Console.WriteLine("Sorry, that is not a whole number.")
            _firstNumber = AcceptFirstNumber(_firstNumber)
        End Try

        Return _firstNumber
    End Function

    Function AcceptSecondNumber(_secondNumber As Integer) As Integer
        Try
            _secondNumber = CInt(Console.ReadLine())
        Catch ex As Exception
            Console.WriteLine("Sorry, that is not a whole number.")
            _secondNumber = AcceptFirstNumber(_secondNumber)
        End Try

        Return _secondNumber
    End Function

    Function AcceptDesiredOperation(_desiredOperation As String) As String
        _desiredOperation = Console.ReadLine()

        If _desiredOperation <> "1" And _desiredOperation <> "2" Then
            Console.WriteLine("Not a valid input, enter 1 for + or enter 2 for *")
            _desiredOperation = AcceptDesiredOperation(_desiredOperation)
        End If

        Return _desiredOperation
    End Function
End Module
