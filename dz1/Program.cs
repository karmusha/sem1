// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

{Console.WriteLine("Напишите первое число: ");
var read = Console.ReadLine();
var a = Convert.ToInt32(read);

Console.WriteLine("Напишите второе число: ");
read = Console.ReadLine();
var b = Convert.ToInt32(read);
int max;

if (a > b) 
{
    max = a;
    Console.WriteLine("Максимальное число: ");
    Console.WriteLine(max);
} 
else 
{
    max = b;
    Console.WriteLine("Максимальное число: ");
    Console.WriteLine(max);
}}


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

{Console.WriteLine("Напишите первое число: ");
var read = Console.ReadLine();
var a = Convert.ToInt32(read);

Console.WriteLine("Напишите второе число: ");
read = Console.ReadLine();
var b = Convert.ToInt32(read);

Console.WriteLine("Напишите третье число: ");
read = Console.ReadLine();
var c = Convert.ToInt32(read);

int max;

if (a > b && a > c) 
{
    max = a;
    Console.WriteLine("Максимальное число: ");
    Console.WriteLine(max);
} 
else if (b > a && b > c)
{
    max = b;
    Console.WriteLine("Максимальное число: ");
    Console.WriteLine(max);
}
else 
{
    max = c;
    Console.WriteLine("Максимальное число: ");
    Console.WriteLine(max);
}}

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

{Console.WriteLine("Напишите число: ");
var read = Console.ReadLine();
var a = Convert.ToInt32(read);
var div = a % 2;

if (div == 0) 
{
    Console.WriteLine("{0} - чётное число", a);
} 
else 
{
    Console.WriteLine(a);
    Console.WriteLine("{0} - нечётное число", a);
}}


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

{Console.WriteLine("Напишите число: ");

var read = Console.ReadLine();
var N = Convert.ToInt32(read);
var count = 1;

while (count <= N)
{
    var div = count % 2;
    if (div == 0)
    { 
        Console.WriteLine(count);
    }
    count++;
}}

//------------ DZ 8 ------------
//Методы:

int[,] CreateCustomArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

int[,,] Fill3DArray(int x_size, int y_size, int z_size)
{
    int[,,] array = new int[x_size, y_size, z_size];

    Random random = new Random();

    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                do
                {
                    array[x, y, z] = random.Next(1, 100);
                }
                while (FindDuplicates(array, x, y, z));
            }
        }
    }
    return array;
}

bool FindDuplicates(int[,,] array, int x, int y, int z)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (i == x && j == y && k == z)
                    return false;

                if (array[x, y, z] == array[i, j, k])
                {
                    return true;
                }
            }
        }
    }

    return false;
}

int[,] Fill2DArray(int a)
{
    int[,] res = new int[a, a];
    int size = res.GetLength(0);
    int number = 1;
    while (size > 0)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                res[i, j] = number;
                number++;
                if (j == size-1)
                {
                    size--;
                    for (int k = i + 1; k <= size; k++)
                    {
                        res[k, j] = number;
                        number++; 
                    }
                    int m = i + size;
                    for (int l = j-1; l >= 0; l--)
                    {
                        res[m, l] = number;
                        number++;
                        if (l == 0)
                        {
                            size--;
                            for (int p = m-1; p > 0 ; p--)
                            {
                                res[p, l] = number;
                                number++;
                            }
                        }
                    }
                }
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void Print3DArray(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write($"{array[x, y, z]} ({x},{y},{z})  ");
            }
        }
        Console.WriteLine();
    }
}

void SortRes(int[,] res, int i, int j)
{
    int prev_index = j - 1;

    if (prev_index < 0)
    {
        return;
    }

    if (res[i, j] > res[i, prev_index])
    {
        int temp = res[i, j];
        res[i, j] = res[i, prev_index];
        res[i, prev_index] = temp;

        SortRes(res, i, prev_index);
    }
}

int[,] SortDescendinInRows(int[,] array)
{
    int[,] res = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            res[i, j] = array[i, j];
            SortRes(res, i, j);
        }
    }
    return res;
}

int GetMinimumSumWithinRows(int[,] array)
{
    int res = 1;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (i == 0)
        {
            minSum = sum;
        }
        if (sum < minSum)
        {
            minSum = sum;
            res = i + 1;
        }
        Console.WriteLine($"Сумма элеметнтов в строке {i + 1} равна {sum}.");
    }
    return res;
}

int SumArray(int[,] array1, int[,] array2, int row_index, int column_index)
{
    int sum = 0;

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        sum += array1[row_index, i] * array2[i, column_index];
    }
    return sum;
}

int[,] FindProductOfTwoArrays(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array1.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            result[i, j] = SumArray(array1, array2, i, j);
        }
    }
    return result;
}

// --- РЕШЕНИЯ ---

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*Console.WriteLine("Введите длину массива");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

Console.WriteLine("Введите ширину массива");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine();
if (!isNumberM || !isNumberN || m < 1 || n < 1)
{
    Console.WriteLine("Вы ввели неверную размерность массива.");
    return;
}
int[,] array54 = CreateCustomArray(m,n);
Print2DArray(array54);
Console.WriteLine();
int[,] result54 = SortDescendinInRows(array54);
Print2DArray(result54);*/


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*Console.WriteLine("Введите длину/ширину массива");
bool isNumberSize = int.TryParse(Console.ReadLine(), out int size);
if (!isNumberSize || size < 1)
{
    Console.WriteLine("Вы ввели неверную размерность массива.");
    return;
}

int[,] array56 = CreateCustomArray(size,size);
Print2DArray(array56);
Console.WriteLine();
int result56 = GetMinimumSumWithinRows(array56);
Console.WriteLine();
Console.WriteLine($"В строке номер {result56} сумма элементов является наименьшей.");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] array581 = CreateCustomArray(size,size);
int[,] array582 = CreateCustomArray(size,size);
Print2DArray(array581);
Console.WriteLine();
Print2DArray(array582);*/
// int[,] array581 = new int[,]
// {
//     {2,4},
//     {3,2}
// };
// Console.WriteLine();

// int[,] array582 = new int[,]
// {
//     {3,4},
//     {3,3}
// };
/*
Console.WriteLine();
int[,] result58 = FindProductOfTwoArrays(array581, array582);
Print2DArray(result58);*/


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int x=2,y=2,z=2;

// int[,,] array60 = Fill3DArray(x,y,z);
// Print3DArray(array60);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// Кусерявый код
int[,] fill_array(int dimension) {
    int[,] res = new int[dimension, dimension]; 
    int total_numbers = dimension * dimension;
    int current_size = dimension;
    int start_x = 0, start_y = 0;
    int number = 1;

    while(number <= total_numbers) {
        var (x, y) = find_x_and_y(number, start_x, start_y, current_size);
        res[x, y] =  number;
        number++;

        start_x++;
        start_y++;
        current_size = (current_size - 2);
    }
    // for(int number = 0; number <= total_numbers; number++) {
    //     var (x, y) = find_x_and_y(res, start_x, start_y, current_size);

    //     res[x, y] = number;

    //     current_size = (current_size - 2);
    // }

    return res;
}

((int, int), int) find_circle_index(int number, int offset, int current_size, int current_circle = 0) {
    int current_numbers = (current_size-1) * 4;

    if (current_numbers <= 0) {
        return ((current_circle+1, current_circle+1), current_size);
    }

    if (offset + current_numbers > number - 1) {
        return ((current_circle, current_circle), current_size);
    }

    current_size -= 2;
    offset += current_numbers;
    current_circle++;

    return find_circle_index(number, offset, current_size, current_circle);
}


(int, int) find_x_and_y(int number, int start_x, int start_y, int size) {

    return (0, 0);
}

int a = 4;
int square_side_items = 5;
int total_numbers = square_side_items * square_side_items;
var r = new Random();
int check_for_circle = r.Next(1, total_numbers+1);

// Console.WriteLine($"{find_circle_index(7, 0, square_side_items)}");
// Console.WriteLine($"{find_circle_index(13, 0, square_side_items)}");
// Console.WriteLine($"{find_circle_index(21, 0, square_side_items)}");
Console.WriteLine($"number {check_for_circle} in {find_circle_index(check_for_circle-1, 0, square_side_items)} circle");
// int[,] array62 = fill_array(a);
// Print2DArray(array62);

// int a = 4;
// int[,] array62 = Fill2DArray(a);
// Print2DArray(array62);