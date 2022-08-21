// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго. 25 - 5 - да

Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA == numberB * numberB)
{
    Console.WriteLine("Число А является квадратом");
}
else
{
    Console.WriteLine("Число А не является квадратом");
}