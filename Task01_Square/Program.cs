// Напишите программу, которая на вход принимает число и выдаёт его квадрат. 4 - 16, 3 - 9 и т.д.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sqr = number * number;
Console.WriteLine(sqr);