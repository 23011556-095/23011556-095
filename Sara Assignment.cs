using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("====== C# Multi-Program Menu ======");
            Console.WriteLine("1. Check Even or Odd");
            Console.WriteLine("2. Simple Calculator");
            Console.WriteLine("3. Grade Finder");
            Console.WriteLine("4. Sum of 1 to n");
            Console.WriteLine("5. Multiplication Table");
            Console.WriteLine("6. Factorial Finder");
            Console.WriteLine("7. Reverse a Number");
            Console.WriteLine("8. Find Maximum and Minimum in Array");
            Console.WriteLine("9. Count Even and Odd in Array");
            Console.WriteLine("10. Search a Number in Array");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input! Press any key to continue...");
                Console.ReadKey();
                continue;
            }

            Console.Clear();
            switch (choice)
            {
                case 1:
                    EvenOdd();
                    break;
                case 2:
                    Calculator();
                    break;
                case 3:
                    GradeFinder();
                    break;
                case 4:
                    SumSeries();
                    break;
                case 5:
                    MultiplicationTable();
                    break;
                case 6:
                    Factorial();
                    break;
                case 7:
                    ReverseNumber();
                    break;
                case 8:
                    MaxMinArray();
                    break;
                case 9:
                    CountEvenOddArray();
                    break;
                case 10:
                    SearchInArray();
                    break;
                case 0:
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }
    }

    // 1. Even or Odd
    static void EvenOdd()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(num % 2 == 0 ? $"{num} is Even." : $"{num} is Odd.");
    }

    // 2. Calculator
    static void Calculator()
    {
        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Choose operation (+ - * /): ");
        char op = Convert.ToChar(Console.ReadLine());

        switch (op)
        {
            case '+': Console.WriteLine($"Result: {a + b}"); break;
            case '-': Console.WriteLine($"Result: {a - b}"); break;
            case '*': Console.WriteLine($"Result: {a * b}"); break;
            case '/':
                if (b != 0) Console.WriteLine($"Result: {a / b}");
                else Console.WriteLine("Division by zero not allowed.");
                break;
            default: Console.WriteLine("Invalid operation."); break;
        }
    }

    // 3. Grade Finder
    static void GradeFinder()
    {
        Console.Write("Enter marks (0-100): ");
        int marks = Convert.ToInt32(Console.ReadLine());

        if (marks >= 85) Console.WriteLine("Grade: A");
        else if (marks >= 70) Console.WriteLine("Grade: B");
        else if (marks >= 55) Console.WriteLine("Grade: C");
        else if (marks >= 40) Console.WriteLine("Grade: D");
        else Console.WriteLine("Grade: F");
    }

    // 4. Sum of 1 to n
    static void SumSeries()
    {
        Console.Write("Enter a number n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++) sum += i;
        Console.WriteLine($"Sum of numbers from 1 to {n} is: {sum}");
    }

    // 5. Multiplication Table
    static void MultiplicationTable()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Multiplication Table of {num}:");
        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{num} x {i} = {num * i}");
    }

    // 6. Factorial
    static void Factorial()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int fact = 1;
        int i = 1;
        while (i <= n)
        {
            fact *= i;
            i++;
        }
        Console.WriteLine($"Factorial of {n} is: {fact}");
    }

    // 7. Reverse Number
    static void ReverseNumber()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int reversed = 0;
        while (num > 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num /= 10;
        }
        Console.WriteLine($"Reversed number: {reversed}");
    }

    // 8. Max and Min in Array
    static void MaxMinArray()
    {
        int[] arr = new int[10];
        Console.WriteLine("Enter 10 integers:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int max = arr[0], min = arr[0];
        for (int i = 1; i < 10; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }

        Console.WriteLine($"Maximum: {max}");
        Console.WriteLine($"Minimum: {min}");
    }

    // 9. Count Even and Odd in Array
    static void CountEvenOddArray()
    {
        int[] arr = new int[10];
        int evenCount = 0, oddCount = 0;

        Console.WriteLine("Enter 10 integers:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
            if (arr[i] % 2 == 0) evenCount++;
            else oddCount++;
        }

        Console.WriteLine($"Even numbers: {evenCount}");
        Console.WriteLine($"Odd numbers: {oddCount}");
    }

    // 10. Search in Array
    static void SearchInArray()
    {
        int[] arr = new int[10];
        Console.WriteLine("Enter 10 integers:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter a number to search: ");
        int search = Convert.ToInt32(Console.ReadLine());

        bool found = false;
        for (int i = 0; i < 10; i++)
        {
            if (arr[i] == search)
            {
                found = true;
                break;
            }
        }

        Console.WriteLine(found
            ? $"{search} is found in the array."
            : $"{search} is not found in the array.");
    }
}