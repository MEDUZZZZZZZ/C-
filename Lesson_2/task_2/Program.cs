void FindThirdNum (int number)
{
    if (number / 100 == 0)
    {
    Console.WriteLine($"В числе {number} нет третьей цифры");
    }
    else
    {
        while (number / 1000 > 0)
        {
            number /= 10;
        }
        int third_num = number % 10;
        Console.WriteLine($"Третья цифра числа --> {third_num}");  
   }
}
Console.WriteLine("Данная программа находит третью цифру числа");
Console.Write("Введите число ");
try
{
    int digit_number = Convert.ToInt32 (Console.ReadLine());
    FindThirdNum(digit_number);

}
catch
{
    Console.WriteLine("Введите число в цифровом формате");
}