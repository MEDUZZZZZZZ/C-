Console.Write ("Введите первое целое число: ");
int first_number = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите второе целое число: ");
int second_number = Convert.ToInt32 (Console.ReadLine());
int max_number = first_number;
if (second_number > first_number)
{
    max_number = second_number;
    Console.Write ("max = ");
    Console.WriteLine (max_number);
}
else if (second_number == max_number)
{
    Console.Write ("Вы ввели одинаковые числа :(");
    Console.Write ("max = ");
    Console.WriteLine (max_number);
}
else
{
    Console.Write ("max = ");
    Console.WriteLine (max_number);
}
