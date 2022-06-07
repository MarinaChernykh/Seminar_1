Console.Write("Введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int Number3 = Convert.ToInt32(Console.ReadLine());
int max = Number1;
if (Number2 > max) max = Number2;
if (Number3 > max) max = Number3;
Console.Write("Максимальное число = ");
Console.WriteLine(max);

