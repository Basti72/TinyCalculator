Console.WriteLine("=== Tiny Calculator ===");
Console.Write("Dividend: ");
int.TryParse(Console.ReadLine(), out int dividend);
Console.Write("Divisor: ");
int.TryParse(Console.ReadLine(), out int divisor);

if(divisor == 0)
    throw new DivideByZeroException("Cannot divide by 0!");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Result: {(float)dividend/divisor}");
Console.ResetColor();