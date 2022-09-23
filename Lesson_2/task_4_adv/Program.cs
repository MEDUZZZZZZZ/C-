void FindDelSecondNum (int number)
{
if (number / 10 == 0 ) Console.WriteLine($"В числе {number} нечего удалять"); 
else if (number / 100 == 0) 
{
    int new_digit = number / 10;
    Console.WriteLine($"Новое число {new_digit}");
}
else 
{
    int storage = number;
    double counter = 0;
    while (number / 100 != 0)
    {
        number /= 10;
        counter++;
    }
    double new_first = (number / 10) * Math.Pow (10, counter);
    double new_last = storage % (Math.Pow(10, counter));
    new_first += new_last;
    Console.WriteLine ($"Новое число {new_first}");
}
}
Console.WriteLine("Данная программа находит и удаляет вторую цифру числа");
Console.Write("Введите число ");
try
{
    int digit_number = Convert.ToInt32 (Console.ReadLine());
    FindDelSecondNum(digit_number);
}
catch
{
    Console.WriteLine("Введите число в цифровом формате");
}