// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int[] array = { 8, 6, 58, 102, 85 };
        Array.Reverse(array);
        PrintArray(array);
    }
    static void PrintArray(int[] array, int i = 0)
    {
        if (i < array.Length)
        {
            Console.Write(array[i] + "\t");
            PrintArray(array, i + 1);
        }
    }
}
