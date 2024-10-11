// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет


int firstnumber =  9;
int secondnumber = 4;

// Простой вывод
// if(firstnumber == secondnumber * secondnumber) // true
// {
// System.Console.WriteLine("Yes");
// }
// else
// {
// System.Console.WriteLine("No");
// }
 
// Варианты выводы - первый сложный, второй легче
if(firstnumber == secondnumber * secondnumber) // true
{
System.Console.WriteLine("a = " + firstnumber + " , b = " + secondnumber + " => да");
}
else
{
System.Console.WriteLine($"a = {firstnumber}, b = {secondnumber} => нет");
}