void Task19() // Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно парлиндромом.
{bool HasFiveNumbers(int N)
{
    string five = N.ToString();
    return five.Length == 5;
}

Console.WriteLine("Введите пятизначное число: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int N);

if (!isNumber)
{
    Console.WriteLine("Вы ввели неверное число. Попробуйте ввести другое число.");
    return;
}

N = Math.Abs(N);

if(!HasFiveNumbers(N))
{
    Console.WriteLine("Ваше число не пятизначное. Попробуйте ввести другое число.");
    return;
}

bool IsPalindrome(int N)
{
    string number = N.ToString();
    var arr = number.ToCharArray();
    int i = 0;
    int j = arr.Length - 1;
    while (i < j)
    {
        if (arr[i] != arr[j])
        {
            return false;
        }
        j--;
        i++;
    }
    return true;
}

if (!IsPalindrome(N))
{
    Console.WriteLine($"Число {N} не является палиндромом.");
}
else
{
    Console.WriteLine($"Число {N} является палиндромом.");
}}

Task19(); // Раскомментируйте строку, чтобы посмотреть решение задачи 19 к семинару 3.
    
void Task21() // Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
{
    Console.WriteLine("Введите координату X точки A:");
    bool isNumberXA = int.TryParse(Console.ReadLine(), out int xa);

    Console.WriteLine("Введите координату Y точки A:");
    bool isNumberYA = int.TryParse(Console.ReadLine(), out int ya);

    Console.WriteLine("Введите координату Z точки A:");
    bool isNumberZA = int.TryParse(Console.ReadLine(), out int za);

    Console.WriteLine("Введите координату X точки B:");
    bool isNumberXB = int.TryParse(Console.ReadLine(), out int xb);

    Console.WriteLine("Введите координату Y точки B:");
    bool isNumberYB = int.TryParse(Console.ReadLine(), out int yb);

    Console.WriteLine("Введите координату Z точки B:");
    bool isNumberZB = int.TryParse(Console.ReadLine(), out int zb);

    if (!isNumberXA || !isNumberYA || !isNumberZA || !isNumberXB || !isNumberYB || !isNumberZB)
    {
        Console.WriteLine("Числа введены не верно.");
        return;
    }

    double CalcDistance(int xa, int ya, int xb, int yb, int za, int zb)
    {
        return Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2) + Math.Pow((zb - za),2));
    }

    double result = CalcDistance(xa, ya, xb, yb, za, zb);
    Console.WriteLine(result);
}

Task21(); // Раскомментируйте строку, чтобы посмотреть решение задачи 21 к семинару 3.
    
void Task23() // Задача 23.Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
{
    Console.WriteLine("Введите число");
    bool isNumber = int.TryParse(Console.ReadLine(), out int to);

    if (!isNumber)
    {
        Console.WriteLine("Вы ввели неверное число. Попробуйте ввести другое число.");
        return;
    }

    if (to < 1)
    {
        Console.WriteLine("Вы ввели неверное число. Попробуйте ввести другое число.");
        return;
    }

    int[] CreateSequenceOfCubeOfNumbers(int from, int to)
    {
        int length = to-from+1;
        int[] res = new int[length];
        for (int i = 0; i < res.Length; i++)
        {
            res[i] = (int)Math.Pow(from, 3);
            from++;
        }
        return res;
    }

    int[] cubes = CreateSequenceOfCubeOfNumbers(1, to);
    for (int i = 0; i < cubes.Length; i++)
    {
        Console.Write(cubes[i]);
        if (i < cubes.Length - 1)
            Console.Write(", ");
    }
}

Task23(); // Раскомментируйте строку, чтобы посмотреть решение задачи 23 к семинару 3.