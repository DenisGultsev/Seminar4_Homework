Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());

while (a == 0)
{
    Console.WriteLine("Ошибка: число A должно быть натуральным числом.");
    Console.Write("Пожалуйста, введите число A заново: ");
    a = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

while (b == 0)
{
    Console.WriteLine("Ошибка: число B должно быть натуральным числом.");
    Console.Write("Пожалуйста, введите число B заново: ");
    b = Convert.ToInt32(Console.ReadLine());
}

int result = a;
for (int i = 1; i < b; i++)
{
    result *= a;
}
Console.WriteLine($"{a}, {b} → {result} ({a}ⁿ), где n = {b}.");