// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

{Console.WriteLine("Напишите первое число");
var read = Console.ReadLine();
var a = Convert.ToInt32(read);

Console.WriteLine("Напишите второе число");
read = Console.ReadLine();
var b = Convert.ToInt32(read);
var sqrt = b * b;

bool is_sqrt = a == sqrt;
Console.WriteLine(is_sqrt);

if (is_sqrt == true) 
{
    Console.WriteLine("Число а является квадратным корнем числа b.");
} 
else 
{
    Console.WriteLine("Число а не является квадратным корнем числа b.");
}}


// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

{var week_day = "";
Console.WriteLine("Введите число дня недели.");
var read = Console.ReadLine(); // Если раннее была объявлена переменна read, то удалить "var" в этой строке.
var day_number = Convert.ToInt32(read);

if (day_number == 1) 
{
week_day = "понедельник";
} 

if (day_number == 2) 
{
week_day = "вторник";
}

if (day_number == 3) 
{
week_day = "среда";
}

if (day_number == 4) 
{
week_day = "четверг";
}

if (day_number == 5) 
{
week_day = "пятница";
}

if (day_number == 6) 
{
week_day = "суббота";
}

if (day_number == 7) 
{
week_day = "воскресенье";
}

Console.WriteLine(week_day);}


//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

{Console.WriteLine("Напишите число: ");
var read = Console.ReadLine();
var N = Convert.ToInt32(read);
int count = N * -1;

while (count <= N)
{
    Console.WriteLine(count);
    count++;
}}


//Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.

{Console.WriteLine("Введите трезначное число: ");
var read = Console.ReadLine();
var N = Convert.ToInt32(read);
var div = N / 100;

if (div >= 1 && div < 10)
{
    Console.WriteLine(N % 10);
}
else
{
    Console.WriteLine("Ваше число не трехзначное. Попробуйте ввести другое число.");
}}