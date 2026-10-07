Console.Write("enter a 3-digit number :");
int x = int.Parse(Console.ReadLine());

int hundredsDigit = x / 100;
int tensDigit = (x / 10) % 10;
int onesDigit = x % 10;

Console.WriteLine($"hundreds digit = {hundredsDigit}");
Console.WriteLine($"tens digit = {tensDigit}");
Console.WriteLine($"ones digit = {onesDigit}");