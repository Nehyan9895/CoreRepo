using System;
using Add;
using Subtract;
using Multiply;
using Divide;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testing DLLs...");

        // Addition
        Console.WriteLine("Addition (2 + 3): " + Addition.AddNumbers(200, 3));

        // Subtraction
        Console.WriteLine("Subtraction (5 - 2): " + Subtraction.SubtractNumbers(5, 2));

        // Multiplication
        Console.WriteLine("Multiplication (4 * 3): " + Multiplication.MultiplyNumbers(4, 3));

        // Division
        Console.WriteLine("Division (10 / 2): " + Division.DivideNumbers(10, 2));
    }
}
