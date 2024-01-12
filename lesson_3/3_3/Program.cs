// 3. Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.

int[] numbers = { 2, 8, 3, -4, -8, 1, -2, 5, 8 };
int[] arr = new int[numbers.Length / 2];
int i = 0;

for (i = 0; i < numbers.Length / 2; i++)
{
    arr[i] = numbers[i] * numbers[numbers.Length - 1 - i];
    Console.WriteLine("Результат: " + arr[i]);
}
