// Методы

int[] GetArrayOfIntegers(int[] array, int start)
{
    int filler = start;
    if (start < array.Length)
    {
        array[start-1] = filler;
        GetArrayOfIntegers(array, start++);
        return array;
    }
    else return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
        Console.WriteLine();
    }
}

// Задача 63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> 1, 2, 3, 4, 5

Console.WriteLine("Введите размерность массива, с какого числа хотите начать, он должен быть больше 0.");
bool isNumberFirst = int.TryParse(Console.ReadLine(), out int first);

Console.WriteLine("Введите размерность массива, конечный элемент, он должен быть больше начального числа.");
bool isNumberLast = int.TryParse(Console.ReadLine(), out int last);

if (!isNumberFirst || !isNumberLast || first < 0 || last <= first)
{
    Console.WriteLine("Вы ввели неверные размеры массива.");
    return;
}

int[] array = new int[last-1];
GetArrayOfIntegers(array, first);
PrintArray(array);