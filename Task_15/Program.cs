﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int a;
Console.WriteLine("Введите цифру, обозначающую выходной день недели:");
if (int.TryParse(Console.ReadLine(), out a) && a>0 && a<8)
    if (a>5 && a<8)
        Console.WriteLine("Да, это выходной!");
    else
        Console.WriteLine("Нет, это не выходной :(");
else
    Console.WriteLine("Введено некорректное значение.");