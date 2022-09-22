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

//Task31(); // Раскомментируйте строку, чтобы посмотреть решение задачи 31 к семинару 5.

void Task32() // Задача 32. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, 2]
{
    Console.WriteLine("Введите длину массива:");

    bool isNumber = int.TryParse(Console.ReadLine(), out int length);

    if (!isNumber || length <= 0)
    {
        Console.WriteLine("Неверная длинна массива.");
        return;
    }

    int[] array = FillArray(length);
    PrintArray(array);

    Console.WriteLine("");

    int[] revert = RevertArray(array);
    PrintArray(revert);

    int[] FillArray(int lenght)
    {
        int[] array = new int[lenght];

        Random random = new Random();
        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(-10, 11);
        }
        return array;
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

    int[] RevertArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i]*-1;
        }
        return array;
    }
}

//Task32(); // Раскомментируйте строку, чтобы посмотреть решение задачи 32 к семинару 5.

void Task33() // Задача 33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
{
    Console.WriteLine("Введите длинну массива:");
    bool isNumber = int.TryParse(Console.ReadLine(), out int length);

    if (!isNumber || length < 1)
    {
        Console.WriteLine("Вы ввели неверную длинну массива.");
        return;
    }

    int[] arr = FillArr(length);
    string printArray = ArrToString(arr);

    Console.WriteLine("Введите искомое число от 1 до 100:");
    bool isNumberN = int.TryParse(Console.ReadLine(), out int number);

    if (!isNumberN || number < 1)
    {
        Console.WriteLine("Вы ввели неверное искомое число.");
        return;
    }

    if(!Contains(number, arr))
    {
        Console.WriteLine($"В заданном массиве {printArray} нет искомого числа {number}.");
    }
    else
    {
        Console.WriteLine($"В заданном массиве {printArray} есть искомое число {number}.");
    }

    bool Contains(int number, int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == number)
            {
                return true;
            }
        }
        return false;
    }

    int[] FillArr(int length)
    {
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            Random random = new Random();
            arr[i] = random.Next(1,101);
        }
        return arr;
    }

    // [1, 4, 7]
    string ArrToString(int[] arr)
    {
        string res = "[";
        
        for (int i = 0; i < arr.Length; i++)
        {
            res += arr[i].ToString();

            if (i != arr.Length - 1)
            {
                res += ", ";
            }
        }

        res += "]";

        return res;
    }
}

//Task33(); // Раскомментируйте строку, чтобы посмотреть решение задачи 33 к семинару 5.

void Task35() // Задача 35. Задайте одномерный массив из 123 случайных числа. Найдите количество элементов массива, значения которых лежат в отрезке [10, 99].
// Например, для массива из 5, а не 123 элементов. В своём решении сделайте для 123:
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
{
    int length = 123;
    int[] array = new int[length];

    FillArray(array, length);
    string printArray = ArrayToString(array);
    int result = FindAmountOfNumbers(array, length);
    Console.WriteLine($"В заданном массиве {printArray} количество элементов массива, значения которых лежат в отрезке [10, 99], равно {result}.");

    void FillArray(int[] array, int length)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Random random = new Random();
            array[i] = random.Next(1, 1001);
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

    int FindAmountOfNumbers(int[] array, int lenght)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 10 && array[i] <=99)
            {
                count++;
            }
        }
        return count;
    }
}

//Task35(); // Раскомментируйте строку, чтобы посмотреть решение задачи 35 к семинару 5.

void Task37() // Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
{
Console.WriteLine("Введите длину массива:");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);

if (!isNumber || length <= 1){
    Console.WriteLine("Вы ввели неверную длину массива.");
    return;
}

int[] array = new int[length];
FillArray(array);
string printArray = ArrayToString(array);
Console.WriteLine(printArray);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Random random = new Random();
        array[i] = random.Next(1, 11);
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

int[] ProdOfPairs(int[] array)
{
    int len = Convert.ToInt32(Math.Ceiling(array.Length/2.0));

    int[] res = new int[len];

    for (int i = 0; i < len; i++)
    {
        int j = array.Length - 1 - i;
        int prod = array[i] * array[j];
        res[i] = prod;
    }
    return res;
}

int[] result = ProdOfPairs(array);
string resultSrting = ArrayToString(result);
Console.WriteLine(resultSrting);
}

Task37(); // Раскомментируйте строку, чтобы посмотреть решение задачи 37 к семинару 5.
