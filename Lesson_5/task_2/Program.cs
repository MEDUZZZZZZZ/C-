int [] ArrayGen(int size)
    {
        int [] mas = new int [size];
        for (int idx = 0;idx < size;idx++)
            {
                mas[idx] = new Random().Next(-1000,1001);
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

int GetSum(int[] mas2)
    {   
        int array_sum = 0; 
        for (int idx = 1; idx < mas2.Length; idx++)
            {
                array_sum += mas2[idx];
                idx++;
            }
        return array_sum;
    }

int [] my_array = ArrayGen(12);
PrintArray(my_array);
int sum = GetSum(my_array);
Console.WriteLine($"Сумма чисел на нечетных позициях массива: {sum}!");
