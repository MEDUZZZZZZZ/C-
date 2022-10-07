int [,] DoubleMatrixMaker ()
    {
        Console.Write("Введите число столбцов: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число строк: ");
        int raws = Convert.ToInt32(Console.ReadLine());
        int [,] matrix = new int [columns, raws];
        for (int idx_c = 0; idx_c < matrix.GetLength(0); idx_c++)
            {
                for (int idx_r = 0; idx_r < matrix.GetLength(1); idx_r++)
                    {
                        matrix[idx_c,idx_r] = new Random().Next(1, 100);
                    }
            }
        return matrix;
    }
void DoubleMatrixPrinter (int [,] matrix_1)
{
    Console.WriteLine("Исходная матрица");
    for (int idx_c = 0; idx_c < matrix_1.GetLength(0); idx_c++)
        {
            for (int idx_r = 0; idx_r < matrix_1.GetLength(1); idx_r++)
                {
                    Console.Write($" {matrix_1[idx_c, idx_r]} ");
                }
            Console.WriteLine();
        }
}

int [] [] FindExtra (int [,] matrix_2)
    {
        int [] [] data = new int [2] [];
        int [] for_max = new int [3];
        int [] for_min = new int [3];
        int max_num = matrix_2[0, 0];
        int min_num = matrix_2[0, 0];
        for (int idx_c = 0; idx_c < matrix_2.GetLength(0); idx_c++)
            {
                for (int idx_r = 0; idx_r < matrix_2.GetLength(1); idx_r++)
                    {
                        if (max_num < matrix_2[idx_c, idx_r])
                            {
                                max_num = matrix_2[idx_c, idx_r];
                                for_max[0] = max_num;
                                for_max[1] = idx_c;
                                for_max[2] = idx_r;
                                data[0] = for_max;
                            }
                        else if (min_num > matrix_2[idx_c, idx_r])
                            {
                                min_num = matrix_2[idx_c, idx_r];
                                for_min[0] = min_num;
                                for_min[1] = idx_c;
                                for_min[2] = idx_r;
                                data[1] = for_min;
                            }
                        
                    }
            }
        return data;
    }
    

void PrintData(int[] [] mas_1)
    {
        Console.Write($"Максимальное число: {mas_1[0] [0]}! ");
        Console.WriteLine($"Его индекс: [{mas_1[0] [1]}, {mas_1[0] [2]}]. ");
        Console.Write($"Минимальное число: {mas_1[1] [0]}! ");
        Console.WriteLine($"Его индекс: [{mas_1[1] [1]}, {mas_1[1] [2]}]. ");
    }

int [,] my_matrix = DoubleMatrixMaker();
DoubleMatrixPrinter(my_matrix);
int [] [] minmax = FindExtra(my_matrix);
PrintData(minmax);