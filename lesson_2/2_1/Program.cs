﻿// 1. Напишите программу, которая принимает на вход
//    трёхзначное число и удаляет вторую цифру этого числа.
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine(a / 100 * 10 + a % 10);
