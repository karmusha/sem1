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