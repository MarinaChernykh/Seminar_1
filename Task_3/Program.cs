//Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N
//4 -> -4 -3 -2 -1 0 1 2 3 4 

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = -N; i <= N; i++)
{
    Console.Write(i);
    Console.Write(" ");
    //также можно написать код вывода в строку с пробелом короче: Console.Write($"{i} ");
}

