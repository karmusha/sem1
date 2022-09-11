void Task39() // Задача 39. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем, и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
{
    int[] array = new int[] {1, 2, 3, 4, 5};
    PrintArray(array);
    int[] reverseArray = ReverseArray(array);
    Console.WriteLine();
    PrintArray(reverseArray);

    int[] ReverseArray(int[] array)
    {
        int[] reverseArray = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            reverseArray[i] = array[array.Length - 1 - i];
        }
        return reverseArray;
    }

    void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}");
        }
    }
}

// Task39();

void Task40()// Задача 40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
{
    Console.WriteLine("Введите длину первой стороны:");
    bool isNumber1 = int.TryParse(Console.ReadLine(), out int ab);

    Console.WriteLine("Введите длину второй стороны:");
    bool isNumber2 = int.TryParse(Console.ReadLine(), out int bc);

    Console.WriteLine("Введите длину третьей стороны:");
    bool isNumber3 = int.TryParse(Console.ReadLine(), out int ca);

    if (!isNumber1 || !isNumber2 || !isNumber2 || ab <=0 || bc <= 0 || ca <= 0)
    {
        Console.WriteLine("Вы ввели неверную длину стороны.");
        return;
    }

    bool CheckTriangle(int first, int second, int third)
    {
        if (first > second + third && second > first + third && third > first + second)
        {
            return false;
        }
        return true;
    }

    if (!CheckTriangle(ab, bc, ca))
    {
        Console.WriteLine($"Треугольника со сторонами, длины которых равны {ab}, {bc}, {ca}, существовать не может.");
        return;
    }

    Console.WriteLine($"Треугольник со сторонами, длины которых равны {ab}, {bc}, {ca}, может существовать.");
}

//Task40();

void Task42()// Задача 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
{
    Console.WriteLine("Введите десятичное число:");
    bool isNumber = int.TryParse(Console.ReadLine(), out int number);

    if (!isNumber || number < 0)
    {
        Console.WriteLine("Вы ввели неверное число.");
        return;
    }

    string GetBinarNumber(int n)
    {
        int binar = 2;
        int temp = n;
        string result = "";
        while (temp>0)
        {
            result = $"{result}{temp % binar}";
            temp = temp / binar;
        }
        return result;
    }

    string res = GetBinarNumber(number);

    for(int i = res.Length-1; i >= 0; i--) {
        Console.Write(res[i]);
    }
    // Console.WriteLine('\n');
}

// Console.WriteLine("Введите десятичное число:");
// int i = Convert.ToInt32(Console.ReadLine());
// string s = Convert.ToString(i, 2);
// Console.WriteLine("В двоичной системе исчисления это:" + s);

//Task42();


void Task44() // Задача 44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
//       index = 0 1 2 3 4 5 6
//           n = 1 2 3 4 5 6 7
{
    Console.WriteLine("Введитe число N:");
    bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

    int[] Fibonacci(int n)
    {
        int[] fibo = new int[n];
        for (int i = 0; i < n; i++)
        {
            int prev, preprev = 0;

            if (i == 0) {
                prev = 0;
                preprev = 0;
            }
            else if (i == 1) {
                prev = 0;
                preprev = 1;
            }
            else {
                prev = fibo[i-1];
                preprev = fibo[i-2];
            }

            fibo[i] = preprev + prev;
        }
        return fibo;
    }

    string ArrayToString(int[] array)
    {
        string res = "[";
        
        for (int i = 0; i < array.Length; i++)
        {
            res += array[i].ToString();

            if (i != array.Length - 1)
            {
                res += ", ";
            }
        }

        res += "]";

        return res;
    }

    int[] array = Fibonacci(n);
    string printArray = ArrayToString(array);
    Console.WriteLine(printArray);

    // f(1) = 1
    // f(2) = 1
    // f(n) = f(n-1) + f(n-2)
}

//Task44();

void Task45()// Задача 45. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
{
    Console.WriteLine("Введитe длинну массива");
    bool isNumber = int.TryParse(Console.ReadLine(), out int length);

    if (!isNumber || length < 1)
    {
        Console.WriteLine("Идите нахуй");
        return;
    }

    int[] arr = new int[length];

    void FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Random random = new Random();
            array[i] = random.Next(1, 10);
        }
    }

    FillArray(arr);

    int[] CopyArr(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = arr[i];
        }
        return array;
    }

    int[] result = CopyArr(arr);

    string ArrayToString(int[] array)
    {
        string res = "[";
        
        for (int i = 0; i < array.Length; i++)
        {
            res += array[i].ToString();

            if (i != array.Length - 1)
            {
                res += ", ";
            }
        }

        res += "]";

        return res;
    }

    string printArray = ArrayToString(arr);
    Console.WriteLine(printArray);
    printArray = ArrayToString(result);
    Console.WriteLine(printArray);
}

Task45();