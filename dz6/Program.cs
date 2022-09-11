void Task41() // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
{
    Console.WriteLine("Сколько чисел вы хотите ввести?");
    bool isNumber = int.TryParse(Console.ReadLine(), out int length);

    if (!isNumber || length <= 0)
    {
        Console.WriteLine("Попробуйте ввести другую длинну.");
        return;
    }

    int[] array = new int[length]; 

    bool FillArray(int[] array)
    {
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

    void PrintArray(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            if(i < array.Length - 1)
            {
                Console.Write($"{array[i]}, ");
            }
            else
            {
                Console.Write($"{array[i]}");
            }
        }
        Console.Write("]");
    }

    PrintArray(array);
    Console.WriteLine();

    int GetPositiveNumbers(int[] array)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) 
            {
                counter++;
            }
        }
        return counter;
    }

    int result = GetPositiveNumbers(array);
    Console.WriteLine($"Количество положительных чисел в заданном массиве = {result}.");
}
Task41();

void Task43() // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями:
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
{
    Console.WriteLine("У Вас есть две прямых, заданных уравнениями: 1) y = k1 * x + b1, 2) y = k2 * x + b2.");
    Console.WriteLine("Введите значение k1:");
    bool isNumberK1 = int.TryParse(Console.ReadLine(), out int k1);

    Console.WriteLine("Введите значение b1:");
    bool isNumberB1 = int.TryParse(Console.ReadLine(), out int b1);

    Console.WriteLine("Введите значение k2:");
    bool isNumberK2 = int.TryParse(Console.ReadLine(), out int k2);

    Console.WriteLine("Введите значение b2:");
    bool isNumberB2 = int.TryParse(Console.ReadLine(), out int b2);

    if (!isNumberK1 || !isNumberB1 || !isNumberK2 || !isNumberB2)
    {
        Console.WriteLine("Числа введены не верно.");
        return;
    }

    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.WriteLine("Прямые совпадают.");
            return;
        }
        else
        {
            Console.WriteLine("Прямые параллельны.");
            return;
        }
    }

    (double, double) GetXY(int b2, int b1, int k1, int k2)
    {
        double x = (b2 - b1) / (double)(k1 - k2);
        double y = k1 * x + b1;
        return (x, y);
    }

    (double x, double y) = GetXY(b2, b1, k1, k2);
    Console.WriteLine($"({x}; {y})");
}
Task43();