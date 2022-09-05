void Task25() // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
{
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

    Console.WriteLine("Введите число А");
    bool isNumberA = int.TryParse(Console.ReadLine(), out int A);

    if (!isNumberA) {
        Console.WriteLine("Вы ввели неверное число А.");
        return;
    }

    Console.WriteLine("Введите число B");
    bool isNumberB = int.TryParse(Console.ReadLine(), out int B);

    if (!isNumberB) {
        Console.WriteLine("Вы ввели неверное число B.");
        return;
    }

    if (B == 0) {
        B = 1;
    }
    
    if (A < 0 || B < 0) {
        Console.WriteLine("Вы ввели отрицательное число. Введите целое число.");
        return;
    }

    int GetPow(int A, int B){
        int pow = 1;        
        for(int i = 0; i < B; i++){
            pow = pow * A;
        }
        return pow;
    }

    int result = GetPow(A, B);
    Console.WriteLine(result);
}

//Task25(); // Раскомментируйте строку, чтобы посмотреть решение задачи 25 к семинару 4.

void Task27() // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
{
    Console.WriteLine("Введите число");
    bool isNumberX = int.TryParse(Console.ReadLine(), out int x);

    if (x < 10){
        Console.WriteLine("Вы ввели маленькое число. Введите число больше или равно 10.");
        return;
    }

    int GetSumOfNumbers(int x){
        int sum = 0;
        int temp = x;
        while (temp > 0){
            int rem = temp % 10;
            sum = sum + rem;
            temp = temp / 10;
        }
        return sum;
    }

    int result = GetSumOfNumbers(x);
    Console.WriteLine($"Сумма цифр в числе {x} равна {result}.");
}

//Task27(); // Раскомментируйте строку, чтобы посмотреть решение задачи 27 к семинару 4.

void Task29() // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
{
    int[] array = new int[8];
    
    bool FillArray(int[] array){
        for (int i = 0; i < array.Length; i++){
            Console.WriteLine("Введите элемент массива");
            bool isNumberR = int.TryParse(Console.ReadLine(), out int r);
            if (!isNumberR){
                return false;
            }
            array[i] = r;
        }
        return true;
    }
    
    if (!FillArray(array)){
        Console.WriteLine("Вы ввели неверный элемент массива");
        return;
    }

    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i]);
        if (i != array.Length - 1) 
            Console.Write(", ");
    }
}

//Task29(); // Раскомментируйте строку, чтобы посмотреть решение задачи 29 к семинару 4.
