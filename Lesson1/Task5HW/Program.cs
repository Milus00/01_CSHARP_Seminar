
//Задача 1 
// Напишите метод, который на вход принимает два целых числа и проверяет,
// делится ли первое число на второе. Если делится, выводите "делится", иначе
// выводите "не делится".


System.Console.Write("Введите первое целое число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе целое число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());


if(firstnumber % secondnumber == 0)
{
    System.Console.WriteLine("Делится");
}
else
{
    System.Console.WriteLine("Не делиться");
}


// Задача 2
// Напишите метод, который принимает на вход три числа и возвращает
// среднее из этих чисел (то есть не самое большое и не самое маленькое).


System.Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if((a >= b && a <= c) && (a >= c && a <= b))
{
    System.Console.Write(a);
}
else if((b >= a && b <= c) && (b >= c && b <= a))
{
    System.Console.Write(b);
}
else
{
    System.Console.Write(c);
}

// Задача 3
// Напишите метод, который на вход принимает число и выводит, является ли
// оно положительным (больше нуля), отрицательным (меньше нуля) или нулём.

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if( number >= 0)
{
    System.Console.WriteLine("положительное");
}
else
{
    System.Console.WriteLine("отрицательное");
}

// Задача 4 Корректно
// Напишите метод, который на вход принимает число (number), а на выходе
// выводит все нечетные числа от 1 до number (включительно), после каждого числа
// должен быть знак пробела

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = 1;


while(i <= number)
{
    if(i % 2 == 1)
    Console.Write (i + " ");
    i++;
}
