// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int a;
Console.WriteLine("Введите трехзначное число:");
if (int.TryParse(Console.ReadLine(), out a) && a>99 && a<1000)
    Console.WriteLine((a%100-a%10)/10);
else
    Console.WriteLine("Введено некорректное значение.");