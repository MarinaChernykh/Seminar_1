Console.Write("Введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());
if (Number1 > Number2)
{
    Console.Write("max = ");
    Console.WriteLine (Number1);
    Console.Write("min = ");
    Console.WriteLine (Number2);
}
if (Number2 > Number1)
{
    Console.Write("max = ");
    Console.WriteLine (Number2);
    Console.Write("min = ");
    Console.WriteLine (Number1);
}
if (Number1 == Number2)
    Console.WriteLine ("Числа равны");
