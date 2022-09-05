void Task24() // Задача 24. Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
{
    Console.WriteLine("Введите число");
    bool isNumberA = int.TryParse(Console.ReadLine(), out int A);

    if (isNumberA == false)
    {
        Console.WriteLine("Число введено неверно.");
        return;
    }

    int result = GetSumNumber(A);
    Console.WriteLine(result);

    int GetSumNumber(int A)
    {
        int sum = 0;
        for (int i = 1; i <= A; i++)
        {
            sum += i;
        }
        return sum;
    }
}

void Task26() // Задача 26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
{
    Console.WriteLine("Введите число");
    bool isNumber = int.TryParse(Console.ReadLine(), out int number);

    if (isNumber == false)
    {
        Console.WriteLine("Вы ввели неверное число.");
        return;
    }

    // int GetNumberOfChars(int numberAbs)
    // {
    //     string arr = numberAbs.ToString();
    //     return arr.Length;
    // }

    int GetNumberOf(int number) {
        int res = number == 0 ? 1 : 0;
        int temp = number < 0  ? -number : number;

        while(temp > 0) {
            temp = temp / 10;
            res++;
        }

        return res;
    }

    // int num = GetNumberOfChars(numberAbs);
    int num = GetNumberOf(number);
    Console.WriteLine($"Количество цифр в заданном числе {number}: {num}.");
}

void Task28() // Задача 28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
{
    Console.WriteLine("Введите число");
    bool isNumberN = int.TryParse(Console.ReadLine(), out int N);

    if (isNumberN == false){
        Console.WriteLine("Вы ввели неверное число.");
        return;
    }
    if (N <= 0){
        Console.WriteLine("Вы ввели неверное число.");
        return;
    }

    int GetProd(int N){
        int prod = 1;
        while (N > 0){
            prod = prod * N;
            N--;
        }
        return prod;
    }

    int production = GetProd(N);
    Console.WriteLine($"Произведение чисел от 1 до {N} равно {production}.");
}

void Task30() // Задача 30. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
{
    int lenght = 8;
    int[] array = new int[lenght];
    
    void FillArray(int[] array){
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++){
            int r = rnd.Next(0, 2);
            array[i] = r;
        }
    }

    FillArray(array);
    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i]);
        if (i != array.Length - 1) 
            Console.Write(", ");
    }
}

// Task24(); // Раскомментируйте строку, чтобы посмотреть решение задачи 24 к семинару 4.
// Task26(); // Раскомментируйте строку, чтобы посмотреть решение задачи 26 к семинару 4.
// Task28(); // Раскомментируйте строку, чтобы посмотреть решение задачи 28 к семинару 4.
Task30(); // Раскомментируйте строку, чтобы посмотреть решение задачи 30 к семинару 4.

