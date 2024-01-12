// Задача 2: Напишите программу, которая принимает на вход координаты 
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной 
// четверти плоскости, в которой находится эта точка.
Console.WriteLine("Впишите X: ");
int X = int.Parse(Console.ReadLine()!);
Console.WriteLine("Впишите Y: ");
int Y = int.Parse(Console.ReadLine()!);

if (X > 0 && Y > 0)
{
    Console.WriteLine("Вы находитесь в первой координатной плоскости");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Вы находитесь во второй координатной плоскости");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Вы находитесь в третьей координатной плоскости");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("Вы находитесь в четвертой координатной плоскости");;
}