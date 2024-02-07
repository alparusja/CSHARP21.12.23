// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("m = ");
        int m = Convert.ToInt32(Console.ReadLine()!);
        System.Console.WriteLine("n = ");
        int n = Convert.ToInt32(Console.ReadLine()!);
        Console.WriteLine(Ackerman(m, n));
    }
    static int Ackerman(int m, int n)
    {
        if (m < 0 || n < 0) throw new ArgumentOutOfRangeException();
        if (m == 0) return n + 1;
        if (n == 0) return Ackerman(m - 1, 1);
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
}
