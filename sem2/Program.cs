// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

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

