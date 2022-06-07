Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 1)
{
    int i = 2;
    while (i <= N)
    {
        Console.Write($"{i} ");
        i += 2;
    }
}
if (N < -1)
{
    int i = -2;
    while (i >= N)
    {
        Console.Write($"{i} ");
        i -= 2;
    }
}
if (N<=1 && N>=-1)
{
    Console.WriteLine("Четных чисел нет");
}
