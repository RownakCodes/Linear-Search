Module Module1

    Sub Main()


        Dim size, find, pos As Integer

        Console.WriteLine("how big of an array do you want? ")
        size = Console.ReadLine - 1
        Console.Clear()

        Dim arr(size) As Integer
        For x = 0 To size
            Console.WriteLine("Enter {0} no. value", x + 1)
            arr(x) = Console.ReadLine()
        Next

    
    
        Console.Clear()
        Console.WriteLine("which value do you want to ensure if you entered?")
        find = Console.ReadLine()
    
        Dim found As Boolean
    
        For x = 0 To UBound(arr)
            If arr(x) = find Then
                found = True
                pos = x
                Exit For
            End If
        Next


        If found = True Then
            Console.WriteLine("you entered the number {0}, and it is in index: {1}", find, pos)
        Else
            Console.WriteLine("It ain't in the list you entered!")
        End If

    End Sub

End Module
