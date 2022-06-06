Console.WriteLine ("Введите трехзначное число");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA < 100 || numberA > 999) Console.WriteLine("Введенное число - не трехзначное");
else 
    Console.WriteLine (numberA%10);
