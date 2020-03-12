Module Module1

    Sub Main()
        'David M Kinnen
        '12.03.2020
        'A program that shows examples of:
        'Count-controlled iteration in FOR i and FOR EACH loops;
        'Condition-controlled iteration in REPEAT... UNTIL loops;
        'Condition-controlled iterationin WHILE... loops

        'Menu to select FOR, REPEAT... UNTIL or WHILE
        Dim menuOption As Integer
        DisplayMenu()
        menuOption = validateMenuOption(1, 3)
        Select Case menuOption
            Case 1

            Case 2
            Case 3
        End Select

        Console.ReadLine()
    End Sub

    Sub DisplayMenu()
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("A program that shows examples of:
        Count-controlled iteration in FOR i and FOR EACH loops;
        Condition-controlled iteration in REPEAT... UNTIL loops;
        Condition-controlled iterationin WHILE... loops.")
        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.White

        Console.WriteLine("1. FOR loops")
        Console.WriteLine("2. REPEAT UNTIL loops")
        Console.WriteLine("3. WHILE loops")
    End Sub

    Function validateMenuOption(lowerLimit As Integer, upperLimit As Integer)
        Dim menuOption As Integer
        Do
            Try
                Console.WriteLine()
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("Please enter the menu option: ")
                Console.ForegroundColor = ConsoleColor.Yellow
                menuOption = Int32.Parse(Console.ReadLine())
                If menuOption < lowerLimit Or menuOption > upperLimit Then
                    Throw New Exception
                End If
            Catch ex As Exception
                Console.WriteLine($"Please enter an option between {lowerLimit} and {upperLimit}.")
            End Try
        Loop Until menuOption >= lowerLimit And menuOption <= upperLimit
        Return menuOption
    End Function

    Sub DisplayForLoops()

    End Sub

    Sub DisplayRepeatUntilLoops()

    End Sub

    Sub DisplayWhileLoops()

    End Sub

End Module
