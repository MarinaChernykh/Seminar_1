//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает последнюю цифру этого числа (456 -> 6)

Console.WriteLine ("Введите трехзначное число");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA < 100 || numberA > 999) Console.WriteLine("Введенное число - не трехзначное");
else 
    Console.WriteLine (numberA%10);
