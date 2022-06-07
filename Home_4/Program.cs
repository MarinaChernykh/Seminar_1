// Задача 8
// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все четные числа от 1 до N

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 1)
{
    for (int i = 2; i <= N; i += 2)
    {
        Console.Write($"{i} ");
    }
}

if (N < -1)
{
    for (int i = -2; i >= N; i -= 2)
    {
        Console.Write($"{i} ");
    }
}
if (N <= 1 && N >= -1) Console.WriteLine("Четных чисел нет");