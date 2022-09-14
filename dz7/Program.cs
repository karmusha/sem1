void Task47()// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
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

    var array = CreateCustomArray(m, n);
    Print2DArray(array);

    void Print2DArray(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0:0.0} ", array[i, j]);
            }
            Console.WriteLine();
        }
    }

    double[,] CreateCustomArray(int m, int n)
    {
        var array = new double[m, n];

        var random = new Random();

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.NextInt64(-100, 100) / 10.0;
            }
        }
        return array;
    }
}

// Task47();


void Task50() // Задача 50. Напишите программу, которая на вход принимает число и ищет в двумерном массиве, и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 7 -> 0 , 2
// 5 -> 1 , 0
// 18 -> нет такого элемента
{
    Console.WriteLine("Введиде длинну массива");
    bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

    Console.WriteLine("Введиде ширину массива");
    bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
    Console.WriteLine();

    if (!isNumberM || !isNumberN || m < 1 || n < 1)
    // Я бы разбила эти проверки на 4 if'a, но для краткости оставила пока так.
    {
        Console.WriteLine("Вы ввели неверную размерность массива.");
        return;
    }

    Console.WriteLine("Введите искомое число от -10 до 10.");
    bool isNumber = int.TryParse(Console.ReadLine(), out int number);
    Console.WriteLine();

    if (!isNumber)
    {
        Console.WriteLine("Вы ввели не число.");
        return;
    }

    if (number < -10 || number > 10)
    {
        Console.WriteLine("Вы ввели число за рамками выборки. Нужно ввести число от -10 до 10.");
        return;
    }

    var array = CreateCustomArray(m, n);
    Print2DArray(array);
    Console.WriteLine();
    (int resRow, int resColumn) = FindNumberInArray(array, number);
    if (resRow != -1 && resColumn != -1)
    // Можно, наверное убрать условие && resColumn != -1.
    {
        Console.WriteLine($"Искомое число {number} найдено в заданном массиве на позиции [{resRow}, {resColumn}]");
    }
    else
    {
        Console.WriteLine("В данном массиве искомое число не найдено.");
    }


    (int, int) FindNumberInArray(int[,] array, int num)
    {
        int row = -1;
        int column = -1;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (num == array[i, j])
                {
                    row = i;
                    column = j;
                }
            }
        }
        return (row, column);
    }

    void Print2DArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j < array.GetLength(1) - 1)
                {
                    Console.Write($"{array[i, j]}, ");
                }
                else
                {
                    Console.WriteLine($"{array[i, j]}");
                }
            }
        }
    }

    int[,] CreateCustomArray(int m, int n)
    {
        var array = new int[m, n];

        var random = new Random();

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(-10, 10);
            }
        }
        return array;
    }
}

// Task50();

void Task52() // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
{
    Console.WriteLine("Введиде длинну массива");
    bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

    Console.WriteLine("Введиде ширину массива");
    bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
    Console.WriteLine();

    var array = CreateCustomArray(m, n);
    Print2DArray(array);
    Console.WriteLine();
    double[] avg = GetAvgInColumns(array);
    Console.WriteLine($"Среднее арифметическое каждого столбца в заданном массиве равно:");
    PrintDoubleArray(avg);


    double[] GetAvgInColumns(int[,] array)
    {
        double[] avgs = new double[array.GetLength(1)];

        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                avgs[j] += array[i, j];
            }
            avgs[j] = avgs[j] / array.GetLength(0);
        }
        return avgs;
    }

    void Print2DArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j < array.GetLength(1) - 1)
                {
                    Console.Write($"{array[i, j]}, ");
                }
                else
                {
                    Console.WriteLine($"{array[i, j]}");
                }
            }
        }
    }

    void PrintDoubleArray(double[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            if (i < array.Length - 1)
            {
                Console.Write($"{array[i]}; ");
            }
            else
            {
                Console.Write($"{array[i]}");
            }
        }
        Console.Write("]");
    }

    int[,] CreateCustomArray(int m, int n)
    {
        var array = new int[m, n];

        var random = new Random();

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(1, 10);
            }
        }
        return array;
    }
}

Task52();