void isDayOff (int day_num)
{
    if (day_num > 5 & day_num < 8) Console.WriteLine("Ура, выходной!");
    else if (day_num > 0 & day_num < 6) Console.WriteLine("Опять работа (");
    else if (day_num <= 0) Console.WriteLine("Ошибка ввода данных");
    else Console.WriteLine("К сожалению в неделе всего 7 дней");
}
Console.WriteLine("Данная программа принимает циру дня недели и говорит выходной ли это день");
try
{
    Console.Write ("Введите цифру дня недели ");
    int day_num = Convert.ToInt32 (Console.ReadLine());
    isDayOff(day_num);
}
catch
{
    Console.WriteLine ("Введите цирфу");
}
