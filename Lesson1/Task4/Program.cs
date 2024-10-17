// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

System.Console.Write("Введите трехзначное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
// ---------99---------1000--------->
if(number > 99 && number < 1000)
{
// int firstDigit = number / 100;
// int thirdDigit = number % 10;
// int sum = firstDigit + thirdDigit;
// System.Console.WriteLine(sum);
System.Console.WriteLine(number /100 + number % 10); // можно написать одной строкой вместо 4 строк выше, результат будет такой же но читаемость кода сложнее
}
else
{
    System.Console.WriteLine("Введено не трехзначное число!");
}

// 7/2 - это целочисленное деление
// %  - деление с остатком