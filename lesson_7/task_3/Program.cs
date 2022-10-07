int [,] DoubleMatrixMaker ()
    {
        Console.Write("Введите число столбцов: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число строк: ");
        int raws = Convert.ToInt32(Console.ReadLine());
        int [,] matrix = new int [raws, columns];
        for (int idx_c = 0; idx_c < matrix.GetLength(0); idx_c++)
            {
                for (int idx_r = 0; idx_r < matrix.GetLength(1); idx_r++)
                    {
                        matrix[idx_c,idx_r] = new Random().Next(1, 10);
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
double [] FindAverage(int [,] matrix_2)
    {
       double [] avg_array = new double [matrix_2.GetLength(1)];
       for (int idx_r = 0; idx_r < matrix_2.GetLength(1); idx_r++) 
            {
                double sum = 0;
                for (int idx_c = 0; idx_c < matrix_2.GetLength(0); idx_c++)
                    {
                       sum += matrix_2[idx_c,idx_r];
                    }
                double avg = Math.Round(sum/matrix_2.GetLength(0), 1);
                avg_array[idx_r] = avg;
            }
        return avg_array;
    }
void PrintArray(double[] mas1)
    {
        Console.WriteLine("Средние значения: ");
        for (int i=0; i<mas1.Length;i++)
            {
                if (i != mas1.Length - 1) Console.Write($"{mas1[i]}, ");
                else Console.WriteLine($"{mas1[i]}");
            }
    }

int [,] my_matrix = DoubleMatrixMaker();
DoubleMatrixPrinter(my_matrix);
double [] avg_mas = FindAverage(my_matrix);
PrintArray(avg_mas);