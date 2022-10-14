int [,] SpiralMatrixFiller()
    {
        Console.Write("Введите размерность матрицы: ");
        int side_size = Convert.ToInt32(Console.ReadLine());
        int [,] result_matrix = new int [side_size, side_size];
        int data = 10;
        int increment = 0;
        for (int lap = side_size-1; lap > 1; lap--)
            {
                for (int idx = increment; idx <= lap; idx++ )
                    {
                        result_matrix[increment,idx] = data;
                        data++;
                    }
                for (int idx = increment + 1; idx < lap; idx++)
                    {
                        result_matrix[idx,lap] = data;
                        data++;
                    }
                for (int idx = lap; idx > increment; idx--)
                    {
                        result_matrix[lap,idx] = data;
                        data++;
                    }
                for (int idx = lap; idx > increment; idx --)
                    {
                        result_matrix[idx,increment] = data;
                        data++;
                    }
                increment++;
            }
                return result_matrix;
        }


void DoubleMatrixPrinter (int [,] matrix_1)
    {
        Console.WriteLine("Матрица заполненная по спирали: ");
        for (int idx_c = 0; idx_c < matrix_1.GetLength(0); idx_c++)
            {
                for (int idx_r = 0; idx_r < matrix_1.GetLength(1); idx_r++)
                    {
                        Console.Write($"{matrix_1[idx_c, idx_r]}   ");
                    }
                Console.WriteLine();
            }
    }
try
    {
        int [,] my_matrix = SpiralMatrixFiller();
        DoubleMatrixPrinter(my_matrix);    
    }
catch
    {
        Console.WriteLine("Размер задается положительным целым числом");
    }

