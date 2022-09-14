void Task46() // Задача 46. Задайте двумерный массив размером m x n, заполненный случайными целыми числами.
{
    int[,] result = CreateRandomArray(5,6);
    Print2DArray(result);

    void Print2DArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine();
        }
    }

    int[,] CreateRandomArray(int m, int n)
    {
        int[,] array = new int[m, n];

        Random random = new Random();

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(1,100);
            }
        }
        return array;
    }
}

// Task46();

void Task48()// Задача 48. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле A = m + n.
// Выведите полученный массив на экран.
// m = 3, n = 4:
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
{
    Console.WriteLine("Введиде длинну массива");
    bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

    Console.WriteLine("Введиде ширину массива");
    bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

    if (!isNumberM || !isNumberN || m < 1 || n < 1)
    {
        Console.WriteLine("Вы ввели неверную размерность массива.");
        return;
    }

    int[,] result = CreateCustomArray(m,n);
    Print2DArray(result);

    void Print2DArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine();
        }
    }

    int[,] CreateCustomArray(int m, int n)
    {
        int[,] array = new int[m, n];

        Random random = new Random();

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(1,100);
            }
        }
        return array;
    }
}

// Task48();

void Task49()// Задача 49. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
{
    Console.WriteLine("Введиде длинну массива");
    bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

    Console.WriteLine("Введиде ширину массива");
    bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

    if (!isNumberM || !isNumberN || m < 1 || n < 1)
    {
        Console.WriteLine("Вы ввели неверную размерность массива.");
        return;
    }

    int[,] array = CreateCustomArray(m,n);
    Print2DArray(array);
    Console.WriteLine();
    int[,] result = ReplaceEvensInArray(array);
    Print2DArray(result);

    int[,] ReplaceEvensInArray(int[,] arrayToReplace)
    {
        for (int i = 0; i < arrayToReplace.GetLength(0); i++)
        {
            for (int j = 0; j < arrayToReplace.GetLength(1); j++)
            {
                if (i % 2 == 0 && j % 2 == 0)
                {
                    arrayToReplace[i, j] = arrayToReplace[i, j] * arrayToReplace[i, j];
                }
            }
        }
        return arrayToReplace;
    }

    void Print2DArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine();
        }
    }

    int[,] CreateCustomArray(int m, int n)
    {
        int[,] array = new int[m, n];
        
        Random random = new Random();

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(1,100);
            }
        }
        return array;
    }
}

// Task49();

void Task51()// Задача 51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1,1) и т.д.)
{
    Console.WriteLine("Введиде длинну массива");
    bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

    Console.WriteLine("Введиде ширину массива");
    bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
    Console.WriteLine();
    if (!isNumberM || !isNumberN || m < 1 || n < 1)
    {
        Console.WriteLine("Вы ввели неверную размерность массива.");
        return;
    }
    
    int[,] array = CreateCustomArray(m,n);
    Print2DArray(array);
    Console.WriteLine();
    int result = GetSum(array);
    Console.WriteLine(result);

    int GetSum (int[,] array)
    {
        int res = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == j)
                {
                    res += array[i, j];
                }
            }
        }
        return res;
    }

    void Print2DArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine();
        }
    }

    int[,] CreateCustomArray(int m, int n)
    {
        int[,] array = new int[m, n];
        
        Random random = new Random();

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(1,100);
            }
        }
        return array;
    }    
}

Task51();