// 2. Напишите программу, которая принимает на вход трёхзначное
//    число и возводит вторую цифру этого числа в степень, равную
//    третьей цифре.
Console.WriteLine("Впишите трехзначное число: ");
int a = int.Parse(Console.ReadLine()!);
if (a >= 100 && a <= 1000)
{
    int a1 = a % 100 / 10;
    int a2 = a % 10;
    double result = Math.Pow(a1,a2);
    Console.WriteLine(result);

}
else
{
    if (a < 100 || a > 1000)
    {
        Console.WriteLine("Вы ввели не трехзначное число");
    }
}
