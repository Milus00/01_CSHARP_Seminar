﻿// Просим через терминал пользователя ввести число, преобразуем в числовое значение, прибавляем 10 и выводим.
// Это действие чрезе объявление дполнительной переменной

// System.Console.Write("Введите первое число: ");

// string strnumber =  Console.ReadLine();

// int firstnumber  = int.Parse(strnumber);

// System.Console.WriteLine(firstnumber +10);

// То же самое, но проще, без дополнительной переменной

System.Console.Write("Введите первое число: ");
int firstnumber  =  int.Parse(Console.ReadLine());

System.Console.WriteLine(firstnumber +10);