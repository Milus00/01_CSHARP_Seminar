﻿// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2
// Если хотим чтобы задача работала еще и с отрицательными числамиб то добавляем замечание

Console.Write("Введите положительное число: ");
int number  =  Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    System.Console.WriteLine("Вы ввели некорректное чистло!");
}

int i = - number;
while(i <number)
{
    System.Console.Write(i + " , ");
    i++; // i = i+1; // i += 1;
}
System.Console.Write(number);