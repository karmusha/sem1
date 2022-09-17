// Замена местами элементов:
// {
//     int a = 5;
//     int b = 10;
//     int temp = b;
//     b = a;
//     a = temp;
// }

void Task53()// Задача 53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
{
    Console.WriteLine("Введиде длину массива");
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
    int[,] result = ChangeFirstAndLastLinesInArray(array);
    Print2DArray(result);

    int[,] ChangeFirstAndLastLinesInArray(int[,] array)
    {
        int[,] res = new int[array.GetLength(0), array.GetLength(1)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                res[i, j] = array[i, j];
                if (i == 0)
                {
                    res[i, j] = array[array.GetLength(0) - i -1, j];
                }
                if (i == array.GetLength(0) - 1)
                {
                    res[i, j] = array[0, j];
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
                array[i, j] = random.Next(1,10);
            }
        }
        return array;
    }    
}

// Task53();

void Task55() // Задача 55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
{
    Console.WriteLine("Введиде длину массива");
    bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

    Console.WriteLine("Введиде ширину массива (должна совпадать с длиной)");
    bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
    Console.WriteLine();

    if (!isNumberM || !isNumberN || m < 1 || n < 1)
    {
        Console.WriteLine("Вы ввели неверную размерность массива.");
        return;
    }
    
    if (m != n)
    {
        Console.WriteLine("Длина и ширина массива должны быть одинаковыми.");
        return;
    }

    int[,] array = CreateCustomArray(m,n);
    Print2DArray(array);
    Console.WriteLine();
    int[,] result = SwitchRowsAndColumns(array);
    Print2DArray(result);

    int[,] SwitchRowsAndColumns(int[,] array)
    {
        int[,] res = new int[array.GetLength(0), array.GetLength(1)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                res[i, j] = array[j, i];
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
                array[i, j] = random.Next(1,10);
            }
        }
        return array;
    }    
}

// Task55();

void Task57() // Задача 57. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// {1, 9, 9}
// {0, 1, 9}
// Частотный массив:
// 0 встречается 1 раз
// 1 встречается 2 раза
// 9 встречается 3 раза
{
    Console.WriteLine("Введиде длину массива");
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
    (int[,] result, int unique) = CreateFrequencyDictionary(array);
    PrintFrequencyDictionary(result, unique);

    (int[,], int) CreateFrequencyDictionary(int[,] array)
    {
        int[,] result = new int[array.GetLength(0) * array.GetLength(1), 2];
        int unique = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                bool found = false;
                for (int k = 0; k <= unique; k++)
                {
                    if (array[i,j] == result[k, 0])
                    {
                        found = true;
                        result[k,1]++;
                        break;
                    }
                }
                if (found == false)
                {
                    result[unique,0] = array[i,j];
                    result[unique,1]++;
                    unique++;
                }
            }
        }
        return (result, unique);
    }

    void PrintFrequencyDictionary(int[,] result, int unique)
    // Принтует частотный массив
    {
        for (int i = 0; i < unique; i++)
        {
            Console.WriteLine($"Число {result[i,0]} встречается в заданном массиве {result[i,1]} раз(а).");
        }

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
                array[i, j] = random.Next(1,10);
            }
        }
        return array;
    }    
}

//Task57();

void Task59() // Задача 59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент = 1, на выходе получим массив:
// 9 4 2
// 2 2 6
// 3 4 7
{
    Console.WriteLine("Введиде длину массива");
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
    (int minimum0, int minimum1) = FindMinimum(array);
    Console.WriteLine($"Минимальный элемент массива находится на позиции [{minimum0}, {minimum1}] в заданном массиве.");
    Console.WriteLine();
    int[,] result = GetResultArray(array, minimum0, minimum1);
    Print2DArray(result);

    (int, int) FindMinimum(int[,] array)
    // Находим индексы минимального значения массива.
    {
        int min0 = 0;
        int min1 = 0;
        int minNumber = array[0,0];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i,j] < minNumber)
                {
                    minNumber = array[i,j];
                    min0 = i;
                    min1 = j;
                }
            }
        }
        return (min0, min1);
    }

    int[,] GetResultArray(int[,] array, int minimum0, int minimum1)
    // Возвращаем новый массив без строки/столбца с минимальным значением.
    {
        int[,] res = new int[array.GetLength(0) - 1,array.GetLength(1) - 1];
        
        int ii = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (i != minimum0) {
                int jj = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j != minimum1) {
                        res[ii,jj] = array[i,j];
                        jj++;
                    }
                }
                ii++;
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
                array[i, j] = random.Next(1,10);
            }
        }
        return array;
    }    
}

Task59();



void Task61() // Задача 61. Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника.
{

}

// Task61();


