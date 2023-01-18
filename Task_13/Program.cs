// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int a, count=0, result=0;
Console.WriteLine("Введите число:");
if (int.TryParse(Console.ReadLine(), out a))
{   
	if (a<0) 
		a*=-1;
	result=a;
	while (a>0)
    	{
        a=a/10;
        count++;
    	}
	if (count>2)
		Console.WriteLine((result % Math.Pow(10, count-2) - result % Math.Pow(10, count-3)) / Math.Pow(10, count-3));
	else
		Console.WriteLine("Третьей цифры нет.");
}
else
    Console.WriteLine("Введено некорректное значение.");