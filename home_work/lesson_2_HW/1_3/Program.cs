// Задача 3: Напишите программу, которая принимает на вход целое число
// из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.WriteLine("Впишите число от 10 до 99: ");
int a = int.Parse(Console.ReadLine()!);
int max = 0;

if (a > 9 && a < 100)
{
    int num1 = a % 10;
    int num2 = a / 10;
    max = Math.Max(num1, num2);
    Console.WriteLine(max);
}
else
{
    Console.WriteLine("Число не входит в заданный диапазон");
}