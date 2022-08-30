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

{
    Console.WriteLine("Введите X:");
    bool isNumberX = int.TryParse(Console.ReadLine(), out int x);

    Console.WriteLine("Введите Y:");
    bool isNumberY = int.TryParse(Console.ReadLine(), out int y);

    if (isNumberX != true || isNumberY != true)
    {
        Console.WriteLine("Числа введены не верно.");
    }

    bool Validate(int x, int y)
    {
        if (x == 0 || y == 0) return false;
        return true;
    }

    int GetQuater(int x, int y)
    {
        if (x > 0 && y > 0) return 1;
        if (x < 0 && y > 0) return 2;
        if (x < 0 && y < 0) return 3;
        if (x > 0 && y < 0) return 4;

        throw new Exception("Числа не верны.");
    }

    bool isValid = Validate(x, y);
    if (isValid == false)
    {
        Console.WriteLine("Какое-то число равно нулю.");
        return;
    }

    int result = GetQuater(x, y);
    Console.WriteLine(result);
}