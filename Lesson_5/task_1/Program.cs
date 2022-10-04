int [] ArrayGen(int size)
    {
        int [] mas = new int [size];
        for (int idx = 0;idx < size;idx++)
            {
                mas[idx] = new Random().Next(100,1000);
            }
        return mas;
    }


void PrintArray(int[] mas1)
    {
        for (int i=0; i<mas1.Length;i++)
            {
                if (i != mas1.Length - 1) Console.Write($"{mas1[i]}, ");
                else Console.WriteLine($"{mas1[i]}");
            }
    }


int GetEven(int[] mas2)
{
    int even_count = 0;
    foreach (int item in mas2)
        {
            if (item % 2 != 0) even_count++;  
        }
    return even_count;
}

int [] my_array = ArrayGen(12);
PrintArray(my_array);
int count = GetEven(my_array);
Console.WriteLine($"Колличество четных чисел в массиве равно: {count}!");
