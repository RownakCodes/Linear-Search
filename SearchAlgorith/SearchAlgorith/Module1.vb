Module Module1

    Sub Main()

        'Dim mid, start, finish, key As Integer
        'Dim found As Boolean = False

        'start = 0
        'finish = UBound(arr)

        'Console.WriteLine("What do you want to search? ")
        'key = Console.ReadLine()

        'While (start < finish)

        '    mid = CInt((start + finish) / 2)

        '    If arr(mid) = key Then
        '        found = True
        '        Exit While
        '    ElseIf arr(mid) < key Then
        '        start = mid + 1
        '    Else
        '        finish = mid - 1
        '    End If
        'End While

        'If found = True Then
        '    Console.WriteLine("The thing is in the array and is at {0} no. index", mid)
        'Else
        '    Console.WriteLine("Ain't in the array")
        'End If

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
        End If

    End Sub

End Module
