Console.WriteLine ("Данная программа принимает на вход три целых числа и находит максимальное");
Console.Write ("Введите первое целое число: ");
try
    {
        int first_number = Convert.ToInt32 (Console.ReadLine());
        Console.Write ("Введите второе целое число: ");
        int second_number = Convert.ToInt32 (Console.ReadLine());
        Console.Write ("Введите третье целое число: ");
        int third_number = Convert.ToInt32 (Console.ReadLine());
        int max_number = first_number;
        if (max_number >= second_number)
        {
            if (max_number > third_number)
            {
                Console.Write("Максимальное число: "+max_number);
            }
            else
            {
                max_number = third_number;
                Console.Write("Максимальное число: "+max_number);
            }
        }
        else
        {
            max_number = second_number;
            if (max_number >= third_number)
            {
                Console.Write("Максимальное число: "+max_number);
            }
            else
            {
                max_number = third_number;
                Console.Write("Максимальное число: "+max_number);

            }
        }
    }
    catch
    {
        Console.WriteLine("Необходимо вводить целые числа");
    }