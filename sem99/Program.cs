// Методы

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
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length-1) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

// Задача 63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// Задача 65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// N = 5 -> 1, 2, 3, 4, 5
// M = 3, N = 6 -> 3, 4, 5, 6

// Console.WriteLine("Введите размерность массива, с какого числа хотите начать, он должен быть больше 0.");
// bool isNumberFirst = int.TryParse(Console.ReadLine(), out int first);

// Console.WriteLine("Введите размерность массива, конечный элемент, он должен быть больше начального числа.");
// bool isNumberLast = int.TryParse(Console.ReadLine(), out int last);

// if (!isNumberFirst || !isNumberLast || first < 0 || last <= first)
// {
//     Console.WriteLine("Вы ввели неверные размеры массива.");
//     return;
// }

// int[] array = new int[last - first + 1];
// GetArrayOfIntegers(array, first);
// Console.WriteLine();
// PrintArray(array);

// Задача 37. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.WriteLine("Введите число");
bool isNumberX = int.TryParse(Console.ReadLine(), out int x);

if (!isNumberX)
{
    Console.WriteLine("Вы ввели не число.");
    return;
}

if (x < 10)
{
    Console.WriteLine("Вы ввели маленькое число. Введите число больше или равно 10.");
    return;
}

int GetSumOfNumbers(int x, int sum)
{
    sum = sum + x % 10;
    if (x > 0) GetSumOfNumbers(x/10, sum);
    return sum;
}

int sum = 0;
int result = GetSumOfNumbers(x, sum);
Console.WriteLine($"Сумма цифр в числе {x} равна {result}.");

// Задача 69. Напишите программу, которая на вход принимает два числа А и В, и возводит число А в целую степень В с помощью рекурсии.
// А = 3; B = 5 -> 243
// А = 2; B = 3 -> 8

Console.WriteLine("Введите число А");
bool isNumberA = int.TryParse(Console.ReadLine(), out int A);

if (!isNumberA)
{
    Console.WriteLine("Вы ввели неверное число А.");
    return;
}

Console.WriteLine("Введите число B");
bool isNumberB = int.TryParse(Console.ReadLine(), out int B);

if (!isNumberB)
{
    Console.WriteLine("Вы ввели неверное число B.");
    return;
}

if (B == 0)
{
    B = 1;
}

if (A < 0 || B < 0)
{
    Console.WriteLine("Вы ввели отрицательное число. Введите целое число.");
    return;
}

int GetPow(int A, int B)
{
    int pow = 1;        
    for(int i = 0; i < B; i++){
        pow = pow * A;
    }
    return pow;
}

int res = GetPow(A, B);
Console.WriteLine(res);
