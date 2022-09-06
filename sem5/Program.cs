void Task31() // Задача 31. Напишите массив из 12 элементов, заполенный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных чисел.
// Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] сумма положительных чисел равна 29, сумма отрицательных чисел равна -20.
{
    Console.WriteLine("Введите длину массива:");

    bool isNumber = int.TryParse(Console.ReadLine(), out int length);

    if (!isNumber || length <= 0)
    {
        Console.WriteLine("Неверное число.");
        return;
    }

    int[] array = FillArray(length);
    PrintArray(array);

    int sumPositiveNumber = GetSumPositiveNumbersInArray(array);

    Console.WriteLine($"Сумма положительных чисел в массиве равна {sumPositiveNumber}");

    int sumNegativeNumber = GetSumNegativeNumbersInArray(array);

    Console.WriteLine($"Сумма положительных чисел в массиве равна {sumNegativeNumber}");

    int GetSumPositiveNumbersInArray(int[] array)
    {
        int sumPosiviveNumber = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] >= 0)
            {
                sumPosiviveNumber += array[i];
            }
        }
        return sumPosiviveNumber;
    }

    int GetSumNegativeNumbersInArray(int[] array)
    {
            int sumNegaviveNumber = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] < 0)
            {
                sumNegaviveNumber += array[i];
            }
        }
        return sumNegaviveNumber;
    }

    void PrintArray(int[] array)
    {
        if(array.Length == 0)
        {
            Console.WriteLine("Вы ввели неверную длинну массива.");
            return;
        }
        Console.Write("[");
        
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write($"{array[i]},");
        }

        Console.Write(array[array.Length - 1]);
        Console.Write("]");   
    }

    int[] FillArray(int lenght)
    {
        int[] array = new int[lenght];

        Random random = new Random();
        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(-9,10);
        }
        return array;
    }
}

//Task31(); // Раскомментируйте строку, чтобы посмотреть решение задачи 31 к семинару 4.

void Task32() // Задача 32. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоботор.
// [-4, -8, 8, 2] -> [4, 8, -8, 2]
{









}

Task32(); // Раскомментируйте строку, чтобы посмотреть решение задачи 32 к семинару 4.

void Task33() // Задача 33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
{









}

Task33(); // Раскомментируйте строку, чтобы посмотреть решение задачи 33 к семинару 4.
