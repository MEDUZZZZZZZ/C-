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
int [,] SortByRow (int [,] matrix_1)
    {
        int storage;
        for (int idx = 0; idx < matrix_1.GetLength(0) * matrix_1.GetLength(1); idx++)
                        for (int i = 0; i < matrix_1.GetLength(0); i++)
                            {
                                for (int j = 0; j <matrix_1.GetLength(1); j++)
                                    {
                                        if (j+1 < matrix_1.GetLength(1) && matrix_1[i,j] < matrix_1[i, j+1])
                                            {
                                                storage = matrix_1[i, j];
                                                matrix_1[i,j] = matrix_1[i, j+1];
                                                matrix_1[i, j+1] = storage;
                                            }
                                    }
                            }
                        return matrix_1;
                    }
int [,] my_matrix = DoubleMatrixMaker();
DoubleMatrixPrinter(my_matrix);
int [,] new_matrix = SortByRow(my_matrix);
DoubleMatrixPrinter(my_matrix);