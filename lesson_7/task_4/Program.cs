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
                        matrix[idx_c,idx_r] = new Random().Next(-1000, 1000);
                    }
            }
        return matrix;
    }
void DoubleMatrixPrinter (int [,] matrix_1)
    {
        Console.WriteLine("Матрица: ");
        for (int idx_c = 0; idx_c < matrix_1.GetLength(0); idx_c++)
            {
                for (int idx_r = 0; idx_r < matrix_1.GetLength(1); idx_r++)
                    {
                        Console.Write($" {matrix_1[idx_c, idx_r]} ");
                    }
                Console.WriteLine();
            }
    }
int [,] MatrixSorter (int [,] matrix_1)
{
    int [] tmp_mass = new int [matrix_1.GetLength(0) * matrix_1.GetLength(1)];
    int point = 0;
    int storage;
    int idx = 0;
     for (int idx_c = 0; idx_c < matrix_1.GetLength(0); idx_c++)
            {
                for (int idx_r = 0; idx_r < matrix_1.GetLength(1); idx_r++)
                    {
                        tmp_mass[point] = matrix_1[idx_c,idx_r];
                        point++;
                    }
            }
    for (int i = 0; i < tmp_mass.Length; i++)
        {
            for (int j = i+1; j < tmp_mass.Length; j++)
            {
                if (tmp_mass[i] > tmp_mass[j])
                    {
                        storage = tmp_mass[i];
                        tmp_mass[i] = tmp_mass[j];
                        tmp_mass[j] = storage;
                    }
            }
        }
    for (int idx_c = 0; idx_c < matrix_1.GetLength(0); idx_c++)
            {
                for (int idx_r = 0; idx_r < matrix_1.GetLength(1); idx_r++)
                    {
                        matrix_1[idx_c,idx_r] = tmp_mass[idx];
                        idx++;
                    }
            }
            return matrix_1;
}
// Второй вариант функции
// int [,] MatrixSorter (int [,] matrix_1)
//     {
//         int storage;
//         for (int idx_c = 0; idx_c < matrix_1.GetLength(0); idx_c++)
//             {
//                 for (int idx_r = 0; idx_r < matrix_1.GetLength(1); idx_r++)
//                     {
//                         for (int i = 0; i < matrix_1.GetLength(0); i++)
//                             {
//                                 for (int j = 0; j <matrix_1.GetLength(1); j++)
//                                     {
//                                         if (matrix_1[idx_c,idx_r] < matrix_1[i, j])
//                                             {
//                                                 storage = matrix_1[idx_c, idx_r];
//                                                 matrix_1[idx_c,idx_r] = matrix_1[i, j];
//                                                 matrix_1[i, j] = storage;
//                                             }
//                                     }
//                             }
//                     }
//             }
//             return matrix_1;
int [,] my_matrix = DoubleMatrixMaker();
DoubleMatrixPrinter(my_matrix);
int [,] new_matrix = MatrixSorter(my_matrix);
DoubleMatrixPrinter(new_matrix);

