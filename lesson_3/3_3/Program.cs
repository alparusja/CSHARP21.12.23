// 3.
int[] numbers = { 2, 8, 3, -4, 2, -8, 1, -2, 5, 8 };
int[] arr = new int[numbers.Length / 2];
int i = 0;

for (i = 0; i < numbers.Length / 2; i++)
{
    arr[i] = numbers[i] * numbers[numbers.Length - 1 - i];
    Console.WriteLine("Результат: " + arr[i]);
}
