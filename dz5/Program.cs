void Task34() // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
{
    Console.WriteLine("Введите длину массива:");
    bool isNumber = int.TryParse(Console.ReadLine(), out int length);

    if (!isNumber)
    {
        Console.WriteLine("Вы ввели неверную длину массива.");
        return;
    }

    if (length <= 0)
    {
        Console.WriteLine("Вы ввели неверную длину массива.");
        return;
    }

    int[] array = new int[length];

    void FillArray (int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Random random = new Random();
            array[i] = random.Next(100, 1000);
        }
    }

    string ArrayToString(int[] array)
    {
        string res = "[";
        
        for (int i = 0; i < array.Length; i++)
        {
            res += array[i].ToString();

            if (i != array.Length - 1)
            {
                res += ", ";
            }
        }

        res += "]";

        return res;
    }

    FillArray(array);
    string printArray = ArrayToString(array);
    Console.WriteLine(printArray);

    int GetNumberOfEvens(int[] array)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                counter++;
            }            
        }
        return counter;
    }

    int result = GetNumberOfEvens(array);
    Console.WriteLine($"Количество чётных чисел в данном массиве = {result}");
}

// Task34(); // Раскомментируйте строку, чтобы посмотреть решение задачи 34 из домашней работы.

void Task36() // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
{
    Console.WriteLine("Введите длину массива:");
    bool isNumber = int.TryParse(Console.ReadLine(), out int length);

    if (!isNumber)
    {
        Console.WriteLine("Вы ввели неверную длину массива.");
        return;
    }

    if (length <= 0)
    {
        Console.WriteLine("Вы ввели неверную длину массива.");
        return;
    }

    int[] array = new int[length];

    void FillArray (int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Random random = new Random();
            array[i] = random.Next(-9, 10);
        }
    }

    string ArrayToString(int[] array)
    {
        string res = "[";
        
        for (int i = 0; i < array.Length; i++)
        {
            res += array[i].ToString();

            if (i != array.Length - 1)
            {
                res += ", ";
            }
        }

        res += "]";

        return res;
    }

    FillArray(array);
    string printArray = ArrayToString(array);
    Console.WriteLine(printArray);

    int GetSumOfOddElements(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0)
            {
                sum += array[i];
            }            
        }
        return sum;
    }

    int result = GetSumOfOddElements(array);
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {result}.");
}
// Task36(); // Раскомментируйте строку, чтобы посмотреть решение задачи 36 из домашней работы.

void Task38() // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
{
    Console.WriteLine("Введите длину массива:");
    bool isNumber = int.TryParse(Console.ReadLine(), out int length);

    if (!isNumber)
    {
        Console.WriteLine("Вы ввели неверную длину массива.");
        return;
    }

    if (length <= 0)
    {
        Console.WriteLine("Вы ввели неверную длину массива.");
        return;
    }

    int[] array = new int[length];

    void FillArray (int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Random random = new Random();
            array[i] = random.Next(1, 100);
        }
    }

    string ArrayToString(int[] array)
    {
        string res = "[";
        
        for (int i = 0; i < array.Length; i++)
        {
            res += array[i].ToString();

            if (i != array.Length - 1)
            {
                res += ", ";
            }
        }

        res += "]";

        return res;
    }

    FillArray(array);
    string printArray = ArrayToString(array);
    Console.WriteLine(printArray);

    int FindMin(int[] array)
    {
        int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }            
        }
        return min;
    }

    int FindMax(int[] array)
    {
        int max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }            
        }
        return max;
    }

    int FindDiscrepancy(int[] array)
    {
        return FindMax(array) - FindMin(array);
    }

    int result = FindDiscrepancy(array);
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {result}.");
}

Task38(); // Раскомментируйте строку, чтобы посмотреть решение задачи 38 из домашней работы.
