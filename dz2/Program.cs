void Task1() //Задача 10 к семинару 2.
{
    // Напишите программу, которая принимает на вход трёхзначное числа и на выходе показывает вторую цифру этого числа.

    int ReturnSecondNumber(int N)
    {
        return N / 10 % 10;
    }

    bool HasThreeNumbers(int N)
    {
        int div = N / 100;
        return div >= 1 && div < 10;
    }

    Console.WriteLine("Введите трёхзначное число: ");
    var read = Console.ReadLine();
    var N = Convert.ToInt32(read);

    if(HasThreeNumbers(N) == false)
    {
        Console.WriteLine("Ваше число не трёхзначное. Попробуйте ввести другое число.");
    }
    else
    {
        int secondNumber = ReturnSecondNumber(N);
        Console.WriteLine($"Второе число: {secondNumber}");
    }

    Console.WriteLine("Конец первой задачи.");
}

void Task2() //Задача 13 к семинару 2.
{
    // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

    int ReturnPosistionNumber(int number, int position)
    {
        int size = 0;
        while (number > 1000)
        {
            number = number / 10;
            size++;
        }
        var div = number % 10;
        return div;
    }    

    bool HasThreeOrMoreNumbers(int number)
    {
        int div = number / 10;
        return div >= 10;
    }

    Console.WriteLine("Введите число: ");
    var read2 = Console.ReadLine();
    var number = Convert.ToInt32(read2);
    int position = 3;

    if(HasThreeOrMoreNumbers(number) == false)
    {
        Console.WriteLine("У вашего числа нет третьей цифры. Попробуйте ввести другое число.");
    }
    else
    {
        int thirdNumber = ReturnPosistionNumber(number, position);
        Console.WriteLine($"Третье число: {thirdNumber}");
    }

    Console.WriteLine("Конец второй задачи.");
}

void Task3() //Задача 15 к семинару 2.
{
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool DayNum(int daynumber)
{
    return daynumber == 6 || daynumber == 7;
}

Console.WriteLine("Введите число дня недели.");
var readday = Console.ReadLine();
var daynumber = Convert.ToInt32(readday);

if(daynumber < 1 || daynumber > 7)
{
    Console.WriteLine("Введите число от 1 до 7.");
}
else
{
    if(DayNum(daynumber) == false)
    {
        Console.WriteLine("Не выходной.");
    }
    else
    {
        Console.WriteLine("Выходной.");
    } 
}

Console.WriteLine("Конец второй задачи.");
}

//Task1(); // Раскомментируйте строку, чтобы посмотреть решение задачи 10 к семинару 2.
//Task2(); // Раскомментируйте строку, чтобы посмотреть решение задачи 13 к семинару 2.
//Task3(); // Раскомментируйте строку, чтобы посмотреть решение задачи 15 к семинару 2.