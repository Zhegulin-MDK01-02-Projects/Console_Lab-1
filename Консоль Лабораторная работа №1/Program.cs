//модуль
Console.WriteLine("Введите а: ");
sbyte a = Convert.ToSByte(Console.ReadLine());
sbyte b = Math.Abs(a);
Console.WriteLine("Модуль числа а: ");
Console.WriteLine(Convert.ToString(b));

//максимальное
Console.WriteLine("Введите число b: ");
sbyte c = Convert.ToSByte(Console.ReadLine());
Console.WriteLine("Мaксимальное между a и b: ");
Console.WriteLine(Convert.ToString(Math.Max(a, c)));

//квадрвтный корень
Console.WriteLine("Квадрат числа b: ");
Console.WriteLine(Convert.ToString(Math.Sqrt(b)));

//Целая часть десетичного числа
Console.WriteLine("Введите десетичное число d: ");
decimal d = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Целая часть десетичного числа:");
Console.WriteLine(Convert.ToString(Math.Truncate(d)));

// Сравнить поведение всех имеющихся в наличии функций округления при значениях аргумента 4.5 и -4.5.
double m = 4.5;
double n = -4.5;
Console.WriteLine("Все функции округления 4.5: ");
Console.WriteLine(Convert.ToString(Math.Round(m)));
Console.WriteLine(Convert.ToString(Math.Round(m, 5)));
Console.WriteLine(Convert.ToString(Math.Round(m, 4)));
Console.WriteLine(Convert.ToString(Math.Truncate(m)));
Console.WriteLine("Все функции округления -4.5: ");
Console.WriteLine(Convert.ToString(Math.Round(n)));
Console.WriteLine(Convert.ToString(Math.Round(n, 5)));
Console.WriteLine(Convert.ToString(Math.Round(n, 4)));
Console.WriteLine(Convert.ToString(Math.Truncate(n)));