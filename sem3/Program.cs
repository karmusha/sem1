// // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// {string input = Console.ReadLine();

// bool ValidateInput(string input)
// {
//     bool isNumber = int.TryParse(input, out int number);

//     if (!isNumber)
//     {
//         return false;
//     }

//     if (number < 100 && number > -100)
//     {
//         return false;
//     }
//     return true;
// }

// char GetThirdNumber(string number)
// {
//     if (number.Contains("-"))
//     {
//         return number[3];
//     }
//     return number[2];
// }

// bool isValid = ValidateInput(input);

// if (!isValid)
// {
//     Console.WriteLine("No valid number");
//     return;
// }

// char result = GetThirdNumber(input);

// Console.WriteLine(result);}

// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// {
//     Console.WriteLine("Введите X:");
//     bool isNumberX = int.TryParse(Console.ReadLine(), out int x);

//     Console.WriteLine("Введите Y:");
//     bool isNumberY = int.TryParse(Console.ReadLine(), out int y);

//     if (isNumberX != true || isNumberY != true)
//     {
//         Console.WriteLine("Числа введены не верно.");
//     }

//     bool Validate(int x, int y)
//     {
//         if (x == 0 || y == 0) return false;
//         return true;
//     }

//     int GetQuater(int x, int y)
//     {
//         if (x > 0 && y > 0) return 1;
//         if (x < 0 && y > 0) return 2;
//         if (x < 0 && y < 0) return 3;
//         if (x > 0 && y < 0) return 4;

//         throw new Exception("Числа не верны.");
//     }

//     bool isValid = Validate(x, y);
//     if (isValid == false)
//     {
//         Console.WriteLine("Какое-то число равно нулю.");
//         return;
//     }

//     int result = GetQuater(x, y);
//     Console.WriteLine(result);
// }

// Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x и y).

// {
//     Console.WriteLine("Введите номер четверти области координат:");
//     bool isNumberQ = int.TryParse(Console.ReadLine(), out int q);

//     bool IsNum (int q)
//     {
//         if(q >=1 && q <= 4)
//         {
//             return true;
//         }
//         return false;
//     }

//     string Coordinates(int q)
//     {
//         string coord = "";
//         if (q == 1)
//         {
//             coord = "x > 0, y > 0";
//         }
//         if (q == 2)
//         {
//             coord = "x < 0, y > 0";
//         }
//         if (q == 3)
//         {
//             coord = "x < 0, y < 0";
//         }
//         if (q == 4)
//         {
//             coord = "x > 0, y < 0";
//         }
//         return coord;
//     }

//     if (!IsNum(q))
//     {
//         Console.WriteLine("Вы ввели неверный номер области координат. Введите номер от 1 до 4.");
//     }

//     string result = Coordinates(q);
//     Console.WriteLine(result);
// }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3, 6); B (2, 1) -> 5,09
// A (7, -5); B (1, -1) -> 7,21

// {
//     Console.WriteLine("Введите координату X точки A:");
//     bool isNumberXA = int.TryParse(Console.ReadLine(), out int xa);

//     Console.WriteLine("Введите координату Y точки A:");
//     bool isNumberYA = int.TryParse(Console.ReadLine(), out int ya);

//     Console.WriteLine("Введите координату X точки B:");
//     bool isNumberXB = int.TryParse(Console.ReadLine(), out int xb);

//     Console.WriteLine("Введите координату Y точки B:");
//     bool isNumberYB = int.TryParse(Console.ReadLine(), out int yb);

//     if (!isNumberXA || !isNumberYA || isNumberXB != true || isNumberYB != true)
//     {
//         Console.WriteLine("Числа введены не верно.");
//         return;
//     }

//     double CalcDistance(int xa, int ya, int xb, int yb)
//     {
//         return Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2));
//     }

//     double result = CalcDistance(xa, ya, xb, yb);
//     Console.WriteLine(result);
// }

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.

Console.WriteLine("Введите число");
bool isNumber = int.TryParse(Console.ReadLine(), out int to);

int[] CreateSequenceOfSquareOfNumbers(int from, int to)
{
    int length = to-from+1;
    int[] res = new int[length];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = from * from;
        from++;
    }
    return res;
}

int[] squares = CreateSequenceOfSquareOfNumbers(1, to);
for (int i = 0; i < squares.Length; i++)
{
    Console.Write(squares[i]);
    if (i < squares.Length - 1)
        Console.Write(", ");
}
