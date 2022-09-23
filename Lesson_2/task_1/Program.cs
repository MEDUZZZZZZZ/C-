void FindSecondNum (int number)
{
    if (number > 99 & number < 1000)
    {
        int second_num = (number / 10) % 10;
        Console.WriteLine($"Вторая цира --> {second_num}"); 
    }
    else 
    {
        Console.WriteLine("Мне кажется вы ввели не трехзначное число");
    }
}
Console.WriteLine("Данная программа находит вторую цифру трехзначного числа");
Console.Write("Введите трехзначное число ");
try
{
    int digit_number = Convert.ToInt32 (Console.ReadLine());
    FindSecondNum(digit_number);
}
catch
{
    Console.WriteLine("Ошибка ввода, введите число в цифровом формате");
}
