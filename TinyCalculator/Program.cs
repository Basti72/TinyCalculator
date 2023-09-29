Console.WriteLine("=== Tiny Calculator ===");

int dividend = GetNumber("Enter dividend: ");
int divisor = GetNumber("Enter divisor: ");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nResult: {(float)dividend/divisor}");
Console.ResetColor();

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