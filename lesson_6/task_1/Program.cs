int [] InumbersInput ()
    {
        Console.Write("Введите необходимое количество числел: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int [] mas = new int [size];
        for (int idx = 0; idx < size; idx++)
            {
                Console.Write("Введите число: ");
                mas[idx] = Convert.ToInt32(Console.ReadLine());
            }
        return mas;
    }

void PrintArray(int[] mas1)
    {
        Console.WriteLine("Ваши числа: ");
        for (int i=0; i<mas1.Length;i++)
            {
                if (i != mas1.Length - 1) Console.Write($"{mas1[i]}, ");
                else Console.WriteLine($"{mas1[i]}");
            }
    }

int NumberOfPossitive (int [] mas1)
    {
        int pos_count = 0;
        foreach (int item in mas1)
            {
                if (item > 0) pos_count++;
            }
        return pos_count;
    }

try
    {
        int [] my_array = InumbersInput();
        PrintArray(my_array); 
        int possitives = NumberOfPossitive(my_array);
        Console.WriteLine($"Колличество положительных чисел: {possitives}");
    }
catch
    {
        Console.WriteLine("Введите число в цифровом формате");
    }