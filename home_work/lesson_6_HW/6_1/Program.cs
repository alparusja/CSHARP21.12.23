//* Задача 1: Задайте двумерный массив символов (тип char
//* [,]). Создать строку из символов этого массива.

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        System.Console.WriteLine("Введите количество строк: ");
        int Sise_y = int.Parse(Console.ReadLine()!);
        System.Console.WriteLine("Введите количество столбцов: ");
        int Sise_x = int.Parse(Console.ReadLine()!);
         char[,] Mass = charMass(Sise_y, Sise_x);
         Print(Mass);
         string Word = string.Join("", Mass);
        Console.WriteLine(Word);
    }
    static char[,] charMass(int Sise_y, int Sise_x)
    {
        char[,] Mass = new char[Sise_y, Sise_x];
       for (int y = 0; y < Mass.GetLength(0); y++)
        {
            for (int x = 0; x < Mass.GetLength(1); x++)
            {
                Console.WriteLine("Введите элемент: " + "с индексом: " + y + " с идексом: " + x);
                Mass[y, x] = char.Parse(Console.ReadLine()!);
            }
            Console.WriteLine(" ");
        }
        return Mass;
    }
    static void Print(char[,] Mass)
    {
        System.Console.WriteLine("Вывод массива: ");
        int Line_y = Mass.GetLength(0);
        int Columns_x = Mass.GetLength(1);
        for (int y = 0; y < Line_y; y++)
        {
            for (int x = 0; x < Columns_x; x++)
            {
                Console.Write(Mass[y, x] + "\t");
            }
            Console.WriteLine();
        }
    }
}
