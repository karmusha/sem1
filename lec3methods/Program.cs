// Вид 1 (ничего не принимают и ничего не возвращают)

{void Method1()
{
    Console.WriteLine(".....");
}

//Method1(); // Чтобы вызвать этот метод не забываем скобочки.
}
// Вид 2 (что-то принимает, но ничего не возвращает)

{void Method2(string msg)
{
    Console.WriteLine(msg);
}}
//Method2(msg: "Текст сообщения"); // Чтобы явно указать, используется (msg: "Текст сообщения"), иначе просто ("Текст сообщения")

{void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст сообщения", 4);
//Method21(count: 4, msg: "Текст сообщения"); // Если явным образом указать, то можно писать не по порядку.
}
// Вид 3 (ничего не принимают, но что-то возвращает)

{int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Вид 4 (что-то принимают и что-то возвращает)
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

// while (i < count)
// {
//     result = result + text;
//     i++;
// }

//     return result;
// }
}
{string Method4(int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "q");
Console.WriteLine(res);}


// Цикл в цикле: вывод таблицы умножения.

{for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}}

// ====== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

{string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгороде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;

}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();}

// Sort Array from Min to Max

// int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 4, 4 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
        
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 0; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition]) minPosition = j;
//         }

//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);

// Sort Array from Max to Min

int[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 4, 4 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
        
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 0; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr2);
SelectionSort(arr2);

PrintArray(arr2);