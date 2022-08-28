// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

{
    Random random = new Random(); // генерит рандомное число
    int randomNumber = random.Next(10, 100); // ...в диапазоне [10, 99]

    Console.WriteLine(randomNumber);

    int firstNumber = randomNumber / 10;
    int lastNumber = randomNumber % 10;

    Console.WriteLine(firstNumber);
    Console.WriteLine(lastNumber);

    if (firstNumber > lastNumber)
    {
        Console.WriteLine($"Максимальное число равно {firstNumber}"); // Интерполяция. Способ вывести в одну строку.
    }
    else
    {
        Console.WriteLine("Максимальное число равно " + lastNumber);
    }
}

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

{
    Random random = new Random();
    int randomNumber = random.Next(100, 1000);

    Console.WriteLine(randomNumber);

    int firstNumber = randomNumber / 100;
    //int secondNumber = randomNumber / 10 % 10;
    int lastNumber = randomNumber % 10;

    Console.WriteLine($"{firstNumber}{lastNumber}");
    Console.WriteLine("Конец первой задачи 1.");
}

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

{
    Random random = new Random();
    int randomNumber = random.Next(1, 10);
    int randomNumberTwo = random.Next(10, 100);

    Console.WriteLine(randomNumber);
    Console.WriteLine(randomNumberTwo);

    int div = randomNumberTwo % randomNumber;

    if (div == 0)
    {
        Console.WriteLine($"{randomNumberTwo} кратно {randomNumber}.");
    }
    else
    {
        Console.WriteLine($"{randomNumberTwo} не кратно {randomNumber}.");
    }
}

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

string IsSquareOf(int a, int b)
{
    int sqrA = a * a;
    int sqrB = b * b;

    if (a == sqrB)
    {
        return "Первое число является квадратом второго.";
    }
    if (b == sqrA)
    {
        return "Второе число является квадратом первого.";
    }

    return "Ни одно число не является квадратом другого.";
}

{
    Console.WriteLine("Напишите первое число: ");
    var read = Console.ReadLine();
    var a = Convert.ToInt32(read);

    Console.WriteLine("Напишите второе число: ");
    read = Console.ReadLine();
    var b = Convert.ToInt32(read);

    string result = IsSquareOf(a, b);
    Console.WriteLine(result);     

    // if (a == sqrB)
    // {
    //     Console.WriteLine("Первое число является квадратом второго.");
    // }
    // else if (b == sqrA)
    // {
    //     Console.WriteLine("Второе число является квадратом первого.");
    // }
    // else
    // {
    //     Console.WriteLine("Ни одно число не является квадратом другого.");
    // }
}

// Напишите программу, которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23.
{
    Console.WriteLine("Введите число: ");
    var read = Console.ReadLine();
    var a = Convert.ToInt32 (read);

    // bool kratnost = a % 7 == a % 23;
    // Console.WriteLine(kratnost);

    bool IsKratno(int number, int firstDevider, int secondDevider)
    {
        if (number % firstDevider == 0)
        {
            if (number % secondDevider == 0)
            {
                return true;
            }
        }
        return false;
    }

    Console.WriteLine("Введите первый числитель: ");
    read = Console.ReadLine();
    var firstDevider = Convert.ToInt32 (read);
    
    Console.WriteLine("Введите второй числитель: ");
    read = Console.ReadLine();
    var secondDevider = Convert.ToInt32 (read);

    bool result = IsKratno(a, firstDevider, secondDevider);
    Console.Write(result);
}