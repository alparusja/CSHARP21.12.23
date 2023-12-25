// 4. Напишите программу, которая выводит третью с конца цифру
//    заданного числа или сообщает что третьей цифры нет.
Console.WriteLine("Впишите число: ");
int a = int.Parse(Console.ReadLine()!);
if (a >= 100)
{
    int a1 = a / 100 % 10;
    Console.WriteLine(a1);
}
else
{
    if (a < 100)
    {
        Console.WriteLine("Третьей цифры в числе нет");
    }
}