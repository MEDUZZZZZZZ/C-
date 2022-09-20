try
{
    Console.WriteLine ("Программа на вход принимает число и выдаёт, является ли число чётным");
    Console.Write ("Введите целое число: ");
    int number = Convert.ToInt32 (Console.ReadLine());
    int parity = number % 2;
    if (parity == 0)
    {
        Console.WriteLine("Число "+number+" четное!");
    }
    else
    {
        Console.WriteLine("Число "+number+" нечетное!");
    }
}
catch
{
    Console.WriteLine("Необходимо было ввести именно целое число!");
}
