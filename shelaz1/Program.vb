Imports System

Module Module1

    Sub Main()

        Dim unit_price, quantity, discount, discount2, revenue, avg, avg2 As Single
        Console.Write("Enter Unit Price:")
        unit_price = Single.Parse(Console.ReadLine())
        Console.Write("Enter Quantity:")
        quantity = Single.Parse(Console.ReadLine())
        discount = 0.1
        discount2 = 0.15
        revenue = (unit_price * quantity)
        avg = revenue - (revenue * discount)
        avg2 = revenue - (revenue * discount2)

        If quantity >= 100 And quantity <= 120 Then
            Console.Write("The revenue from sale is: ")
            Console.WriteLine(revenue)
            Console.Write("After Discount: ")
            Console.WriteLine(avg)
        ElseIf quantity >= 121 Then
            Console.Write("The revenue from sale is: ")
            Console.WriteLine(revenue)
            Console.Write("After Discount: ")
            Console.WriteLine(avg2)
        ElseIf quantity < 100 Then
            Console.Write("The revenue from sale is: ")
            Console.WriteLine(revenue)
            Console.Write("There is No Discount: ")

        Else : Console.WriteLine("Invalid input")
        End If

        Console.ReadLine()

    End Sub

End Module
