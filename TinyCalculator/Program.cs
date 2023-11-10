Console.WriteLine("=== Tiny Calculator ===");

int dividend = GetNumber("Enter dividend: ");
while(true)
{
    int divisor = GetNumber("Enter divisor: ");

    if (divisor == 0)
    {
        Console.WriteLine("Divisor cannot be 0!");
        return;
    }

    Console.ForegroundColor = ConsoleColor.Green;
    int result = dividend / divisor;
    dividend = (int)result;
    Console.WriteLine($"\nResult: {result}");
    Console.ResetColor();
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