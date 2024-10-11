// Просим через терминал пользователя ввести число, преобразуем в числовое значение, прибавляем 10 и выводим.
// Это действие чрезе объявление дполнительной переменной

// System.Console.Write("Введите первое число: ");

// string strnumber =  Console.ReadLine();

// int firstnumber  = int.Parse(strnumber);

// System.Console.WriteLine(firstnumber +10);

// То же самое, но проще, без дополнительной переменной

// System.Console.Write("Введите первое число: ");
// int firstnumber  =  int.Parse(Console.ReadLine());

// System.Console.WriteLine(firstnumber +10);



//Пример объединения двух задач- попросить ввести данные и вывести ответ
System.Console.Write("Введите первое число: ");
// int firstnumber  =  int.Parse(Console.ReadLine()); // Этот конвектор выдает предупреждения, если пользователь введет неправильные данные, то результатом будет пустота. Чтобы этого избежать используем второй конвектор
int firstnumber  =  Convert.ToInt32(Console.ReadLine()); // все то же самое, но не будут выводить предупреждения в терминал

System.Console.Write("Введите второе число: ");
int secondnumber = int.Parse(Console.ReadLine());

if(firstnumber == secondnumber * secondnumber) // true
{
System.Console.WriteLine("a = " + firstnumber + " , b = " + secondnumber + " => да");
}
else
{
System.Console.WriteLine($"a = {firstnumber}, b = {secondnumber} => нет");
}