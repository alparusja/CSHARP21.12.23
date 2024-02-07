// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные. 

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Задайте произвольную строку из латинских букв (заглавные и строчные): ");
        string s = Console.ReadLine()!;
        string Word = WordToLower(s);
    }
    static string WordToLower(string s)
    {
        string s2 = new string(s);

        Console.WriteLine(s2.ToLower());
        return s2;
    }
}
