void ProgrammistsDeclination (int number)
{
    int if_tens = number % 10;
    int if_hundreeds = number % 100;
    if (if_hundreeds > 10 & if_hundreeds < 15 ) Console.WriteLine ($"{number} Программистов");
    else if (if_tens > 4 & if_tens < 10 ^ if_tens == 0) Console.WriteLine ($"{number} Программистов");
    else if (if_tens > 1 & if_tens < 5) Console.WriteLine($"{number} Программиста");
    else Console.WriteLine ($"{number} Программист");
}
Console.WriteLine("Данная программа склоняет слово программист ");
try
{
    Console.Write ("Введите колдичество программистов ");
    int number = Convert.ToInt32 (Console.ReadLine());
    ProgrammistsDeclination(number);
}
catch
{
    Console.WriteLine ("Введите цирфу");
}
