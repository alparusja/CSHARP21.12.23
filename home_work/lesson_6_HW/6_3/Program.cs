// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        System.Console.WriteLine("Задайте произвольную строку: ");
        string s = Console.ReadLine()!;
        char[] word = WordChar(s); 
        Array.Reverse(word); // переворачиваем строку
        string Pol = WordPal(s,word);
    }

    static char[] WordChar(string s)
    {
       char[] text = s.ToCharArray();
       return text; 
    }
    static string WordPal(string s,char[] word)
    {
        string FinalText = new string(word); // объявим строку с инициализацией символами из массива.
        if(s == FinalText)
        {
            System.Console.WriteLine("Данная запись не является палиндромом");
        }
        if(s != FinalText) // (!=) не равняеться
        {
            System.Console.WriteLine("Данная запись является палиндромом");
        }
        return FinalText;
    }
}
