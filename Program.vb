Imports System
Module Program
    Sub Main(args As String())
        Dim variable As Integer
        Console.WriteLine("Hola quetal usted esta en el Menu:")
        Do Until variable = 4
            Console.WriteLine("opcion 1")
            Console.WriteLine("opcion 2")
            Console.WriteLine("opcion 3")
            Console.WriteLine("SALIR del Menu op 4")
            variable = Console.ReadLine
            If variable = 1 Then
                Console.WriteLine("A puesto la opcion 1")
            ElseIf variable = 2 Then
                Console.WriteLine("A puesto la opcion 2")
            ElseIf variable = 3 Then
                Console.WriteLine("A puesto la opcion 3")
            ElseIf variable = 4 Then
                Console.WriteLine("A SALIDO del Menu")
            End If
        Loop
    End Sub
End Module
