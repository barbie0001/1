using System;

double num1, num2;
int vibordeystviya;

do
{
    Console.WriteLine("Выбирите операцию");
    Console.WriteLine("1 - Сложить два числа");
    Console.WriteLine("2 - Вычесть первое из второго");
    Console.WriteLine("3 - Перемножить два чила");
    Console.WriteLine("4 - Разделить первое на второе");
    Console.WriteLine("5 - Возвести в степень N первое число");
    Console.WriteLine("6 - Найти квадаратный корень из числа");
    Console.WriteLine("7 - Найти 1 процент из числа");
    Console.WriteLine("8 - Выйти из программы");
    vibordeystviya = Convert.ToInt32(Console.ReadLine());

    switch (vibordeystviya)

    {
        case 1:
            Console.WriteLine("Введите первое число");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат сложения = " + (num1 + num2));
            break;
        case 2:
            Console.WriteLine("Введите первое число");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат вычитания = " + (num1 - num2));
            break;
        case 3:
            Console.WriteLine("Введите первое число");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат умножения = " + num1 * num2);
            break;
        case 4:
            Console.WriteLine("Введите первое число");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Рузультат деления = " + num1 / num2);
            break;
        case 5:
            Console.WriteLine("Введите число");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите степень в которую возвести первое число");
            int stepen = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Рузультат возведения num1 в степень N = " + Math.Pow(num1, stepen));
            break;
        case 6:
            Console.WriteLine("Введите число");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Квадратный корень из первого числа = " + Math.Sqrt(num1));
            break;
        case 7:
            Console.WriteLine("Введите число");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" 1% от числа = " + num1 / 100);
            break;
        case 9:
            Console.WriteLine("Действия закончилсь");
            break;
    }
    Console.WriteLine();
} while (vibordeystviya != 8);
