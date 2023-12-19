// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;

class BugExample
{
    static void Main(string[] args)
    {
        int number1 = 10;
        int number2 = 5;
        int result = 0;

        // Bug 1: Incorrect operation, should be subtraction instead of addition
        result = number1 + number2;

        Console.WriteLine("The result of the operation is: " + result);

        // Bug 2: Incorrect method call, should be MultiplyNumbers instead of DivideNumbers
        result = DivideNumbers(number1, number2);

        Console.WriteLine("The result of another operation is: " + result);

        // Bug 3: Invalid variable type, should be float instead of int
        float floatValue = 10.5;

        Console.WriteLine("A floating-point value: " + floatValue);

        // Bug 4: Missing closing parenthesis in the WriteLine statement
        Console.WriteLine("This statement is missing a closing parenthesis);

        // Bug 5: Looping mistake, should start from 1 and end at 10
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Current value: " + i);
        }

        // Bug 6: Infinite loop due to missing increment
        int j = 0;
        while (j < 5)
        {
            Console.WriteLine("Value of j: " + j);
        }

        // Bug 7: Incorrect array initialization, values are placed in the wrong order
        int[] numbers = new int[] { 1, 3, 2, 5, 4 };

        Console.WriteLine("The first number in the array: " + numbers[0]);

        // Bug 8: Accessing an index outside the array's bounds
        Console.WriteLine("An invalid index in the array: " + numbers[10]);
    }

    // Bug 9: Incorrect method signature, should be MultiplyNumbers instead of DivideNumbers
    static int DivideNumbers(int num1, int num2)
    {
        return num1 * num2;
    }
}
