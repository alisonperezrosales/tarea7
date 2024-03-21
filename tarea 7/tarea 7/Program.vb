Imports System

Module Program
    Sub Main(args As String())
        Const rows As Integer = 2
        Const cols As Integer = 2
        Dim A(rows - 1, cols - 1) As Integer
        Console.WriteLine("Ingresar elementos a la matriz")
        For i As Integer = 0 To rows - 1
            For j As Integer = 0 To cols - 1
                Console.Write($"Ingrese el elemento [{i},{j}]:")
                A(i, j) = Convert.ToInt32(Console.ReadLine())
            Next
        Next
        Console.Clear()
        Console.WriteLine("Matriz A:")
        For i As Integer = 0 To rows - 1
            For j As Integer = 0 To cols - 1
                Console.WriteLine($"{A(i, j)}")
            Next
            Console.WriteLine()
        Next
        Console.WriteLine("Matriz transpuesta de A:")
        For i As Integer = 0 To cols - 1
            For j As Integer = 0 To rows - 1
                Console.Write($"{A(j, i)}")
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()
    End Sub
End Module
