﻿
// Задача 7: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("insert number three-digit number:  ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(number % 10);