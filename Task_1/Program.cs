//Напишите программу, которая на вход принимает 2 числа и проверяет, 
//является ли первое число квадратом второго

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB * numberB) Console.WriteLine("Первое число = квадрату второго");
else Console.WriteLine("Первое число - не квадрат второго");
