// 3. Напишите программу, которая будет принимать на вход два
//    числа и выводить, является ли второе число кратным первому.
//    Если второе число некратно первому, то программа выводит
//    остаток от деления.
Console.WriteLine("Впишите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Впишите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if (a % b == 0)
{
    Console.WriteLine("Кратно");;
}
else
{

    Console.WriteLine("Не кратно, остаток " + a % b);
}