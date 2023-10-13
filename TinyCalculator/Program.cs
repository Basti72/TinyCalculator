﻿Console.WriteLine("=== Tiny Calculator ===");

int number1 = GetNumber("Enter first number: ");
char sign = GetOperator("Enter operator: ");
int number2 = GetNumber("Enter second number: ");

if(sign == '/' && number2 == 0)
{
    Console.WriteLine("Divisor cannot be 0!");
    return;
}

Console.ForegroundColor = ConsoleColor.Green;
switch(sign)
{
    case '+': Console.WriteLine($"\nResult: {number1 + number2}"); break;
    case '-': Console.WriteLine($"\nResult: {number1 - number2}"); break;
    case '*': Console.WriteLine($"\nResult: {number1 * number2}"); break;
    case '/': Console.WriteLine($"\nResult: {number1 / number2}"); break;
}
Console.ResetColor();

static char GetOperator(string text)
{
    uint attempts = 0;
    while (true)
    {
        Console.Write(text);
        if (char.TryParse(Console.ReadLine(), out var sign) && (sign == '+' || sign == '-' || sign == '*' || sign == '/'))
            return sign;

        Console.WriteLine("Please enter a valid operator [+, -, /, *]!\n");
        attempts++;
        if (attempts == 10)
        {
            Console.WriteLine("You are too fucking dumb! Bye");
            Environment.Exit(0);
        }
    }
}

static int GetNumber(string text)
{
    uint attempts = 0;
    while(true)
    {
        Console.Write(text);
        if (int.TryParse(Console.ReadLine(), out var number))
            return number;
        Console.WriteLine("Please enter a valid number!\n");
        attempts++;
        if(attempts == 10)
        {
            Console.WriteLine("You are too fucking dumb! Bye");
            Environment.Exit(0);
        }
    }
}