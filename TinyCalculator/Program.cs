Console.WriteLine("=== Tiny Calculator ===");
Console.Write("Dividend: ");
int dividend = int.Parse(Console.ReadLine());
Console.Write("Divisor: ");
int divisor = int.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Result: {(float)dividend/(float)divisor}");
Console.ResetColor();