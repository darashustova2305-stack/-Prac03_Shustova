int max = int.MaxValue;
Console.WriteLine($"int.MaxValue = {max}");

int overflowed = max + 1;
Console.WriteLine($"int.MaxValue + 1 = {overflowed}");

int min = int.MinValue;
Console.WriteLine($"int.MinValue = {min}");

int underflowed = min - 1;
Console.WriteLine($"int.MinValue - 1 = {underflowed}");
