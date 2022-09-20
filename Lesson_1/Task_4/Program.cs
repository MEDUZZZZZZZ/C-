try
{
    Console.WriteLine ("Программа на вход принимает на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N");
    Console.Write ("Введите целое число: ");
    int number = Convert.ToInt32 (Console.ReadLine());
    int pointer = 1;
    if (pointer > number)
    {
        Console.WriteLine ("Вы ввели число меньше единицы");
    }
    else
    {
        while (pointer <= number)
        {
            int parity = pointer % 2;
            if (parity == 0)
            {
                Console.Write(pointer+",");
            }
            pointer++;
        }  
    }
}
catch
{
     Console.WriteLine("Необходимо было ввести именно целое число!");
}