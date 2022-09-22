// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

void GetArrayOfIntegers(int[] array, int first, int i = 0)
{
    if (i < array.Length)
    {
        array[i] = first;
        GetArrayOfIntegers(array, first+1, i+1);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length-1) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]} ");
    }
}

Console.WriteLine("Введите число М");
bool isNumberFirst = int.TryParse(Console.ReadLine(), out int first);

Console.WriteLine("Введите число N, оно должно быть больше M");
bool isNumberLast = int.TryParse(Console.ReadLine(), out int last);

if (!isNumberFirst || !isNumberLast || first < 0 || last <= first)
{
    Console.WriteLine("Вы ввели неверные числа.");
    return;
}

int[] array = new int[last - first + 1];
GetArrayOfIntegers(array, first);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Конец задачи 64.");

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSumOfIntegersBetweenMAndN(int first, int last)
{
    if (first < last)
    {
        return first + GetSumOfIntegersBetweenMAndN(first+1, last);
    }
    else {
        return first;
    }
}

int sum = GetSumOfIntegersBetweenMAndN(first, last);
Console.WriteLine();
Console.WriteLine(sum);
Console.WriteLine("Конец задачи 66.");