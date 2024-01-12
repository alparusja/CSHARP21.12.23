// Задача 4: Напишите программу, которая на вход принимает натуральное
// число N, а на выходе показывает его цифры через запятую.
Console.WriteLine("Впишите натуральное число: ");
int N = int.Parse(Console.ReadLine()!);

string number = "";
if (N > 0)
{
   while (N > 0)
    {
        number = N % 10 + "," + number;
        N = N / 10;
    }
    Console.Write(number.Trim(',') + "\n");
}
else
{
    Console.WriteLine("Ввели не натуральное число");
}