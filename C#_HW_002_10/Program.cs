﻿// Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

var rnd = new Random();
int digit = rnd.Next(100, 1000);

int newDigit = (digit / 10) % 10;
System.Console.WriteLine($"Вторая цифра числа {digit}: {newDigit}");