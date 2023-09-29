Console.WriteLine("=== Tiny Calculator ===");
bool x;
int dividend, divisor;
do
{
    Console.Write("Dividend: ");
    x = int.TryParse(Console.ReadLine(), out dividend);
}
while (!x);

do
{
    Console.Write("Divisor: ");
    x = int.TryParse(Console.ReadLine(), out divisor);
}
while (!x);

if(divisor == 0)
    throw new DivideByZeroException("Cannot divide by 0!");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nResult: {(float)dividend/divisor}");
Console.ResetColor();