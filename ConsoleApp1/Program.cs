using LAB06;
using Range = LAB06.Range;

try
{
    Range range1 = new Range(2, 5);
    Range range2 = new Range(4, 8);

    Console.WriteLine($"Range 1: {range1}");
    Console.WriteLine($"Range 2: {range2}");

    Console.WriteLine($"Объединение: {range1 + range2}");
    Console.WriteLine($"Пересечение: {range1 - range2}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

Console.WriteLine();

try
{
    Range range3 = new Range(10, 2);
    Range range4 = new Range(7, 10);

    Console.WriteLine($"Range 3: {range3}");
    Console.WriteLine($"Range 4: {range4}");

    Console.WriteLine($"Объединение: {range3 + range4}");
    Console.WriteLine($"Пересечение: {range3 - range4}");

}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

Console.WriteLine();

try
{
    Range range5 = new Range(1, 2);
    Range range6 = new Range(7, 10);

    Console.WriteLine($"Range 5: {range5}");
    Console.WriteLine($"Range 6: {range6}");

    Console.WriteLine($"Объединение: {range5 + range6}");
    Console.WriteLine($"Пересечение: {range5 - range6}");

}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
