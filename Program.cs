// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");

var read = Console.ReadLine();
var number = Convert.ToInt32(read); // Конвертация в число.

int result = number * number;

Console.WriteLine(result);

