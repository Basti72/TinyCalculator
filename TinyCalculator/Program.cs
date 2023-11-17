using System.Globalization;

Console.WriteLine("=== Tiny Calculator ===");

int number1 = GetNumber("Enter first number: ");
while(true)
{
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
        case '+': Console.WriteLine($"\nResult: {number1 + number2}"); number1 = number1+number2; break;
        case '-': Console.WriteLine($"\nResult: {number1 - number2}"); number1 = number1-number2; break;
        case '*': Console.WriteLine($"\nResult: {number1 * number2}"); number1 = number1*number2; break;
        case '/': Console.WriteLine($"\nResult: {number1 / number2} with Remainder {number1%number2}"); number1 = number1/number2; break;
        case '^': Console.WriteLine($"\nResult: {Math.Pow(number1, number2)}"); number1 = (int)Math.Pow(number1, number2); break; 
    }
    Console.ResetColor();
}


static char GetOperator(string text)
{
    uint attempts = 0;
    while (true)
    {
        Console.Write(text);
        if (char.TryParse(Console.ReadLine(), out var sign) && (sign == '+' || sign == '-' || sign == '*' || sign == '/' || sign == '^'))
            return sign;

        Console.WriteLine("Please enter a valid operator [+, -, /, *, ^]!\n");
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
        string userinput = Console.ReadLine();
        int number = 0;
        if (userinput.StartsWith("0x"))
        {
            try
            {
                number = Int32.Parse(userinput.Substring(2), NumberStyles.HexNumber);
                return number;
            }
            catch(Exception e)
            {
                continue;
            }
        }
        else if(int.TryParse(userinput, out number))
        {
            return number;
        }
        Console.WriteLine("Please enter a valid number!\n");
        attempts++;
        if(attempts == 10)
        {
            Console.WriteLine("You are too fucking dumb! Bye");
            Environment.Exit(0);
        }
    }
}