using System;

public class MainClass
{
    public static void Main()
    {
        
        Console.WriteLine("Упражнение 4.1 и Упражнение 4.2\n");
        //Написать программу, которая читает с экрана число от 1 до 365(номер дня
        //в году), переводит этот число в месяц и день месяца. Например, число 40 соответствует 9
        //февраля(високосный год не учитывать).
        //Добавить к задаче из предыдущего упражнения проверку числа введенного
        //пользователем.Если число меньше 1 или больше 365, программа должна вырабатывать
        //исключение, и выдавать на экран сообщение.
        Console.Write("Введите номер дня в году от 1 до 365: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int day))
        {
            if (day < 1 || day > 365)
            {
                Console.WriteLine("Ошибка: число должно быть в диапазоне от 1 до 365");
                return;
            }

            DateTime date = new DateTime(2024, 1, 1).AddDays(day - 1);
            switch (date.Month)
            {
                case 1: Console.WriteLine($"День {day} соответствует {date.Day} января"); break;
                case 2: Console.WriteLine($"День {day} соответствует {date.Day} февраля"); break;
                case 3: Console.WriteLine($"День {day} соответствует {date.Day} марта", date.Day); break;
                case 4: Console.WriteLine($"День {day} соответствует {date.Day} апреля"); break;
                case 5: Console.WriteLine($"День {day} соответствует {date.Day} мая"); break;
                case 6: Console.WriteLine($"День {day} соответствует {date.Day} июня"); break;
                case 7: Console.WriteLine($"День {day} соответствует {date.Day} июля"); break;
                case 8: Console.WriteLine($"День {day} соответствует {date.Day} августа"); break;
                case 9: Console.WriteLine($"День {day} соответствует {date.Day} сентября"); break;
                case 10: Console.WriteLine($"День {day} соответствует {date.Day} октября"); break;
                case 11: Console.WriteLine($"День {day} соответствует {date.Day} ноября"); break;
                case 12: Console.WriteLine($"День {day} соответствует {date.Day} декабря"); break;
            }
        }
        else
        {
            Console.WriteLine("Ошибка: некорректное число");
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////

        Console.WriteLine("\nДомашнее задание 4.1\n");
        //Изменить программу из упражнений 4.1 и 4.2 так, чтобы она
        //учитывала год(високосный или нет). Год вводится с экрана. (Год високосный, если он
        //делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный
        //год.Однако, если он делится без остатка на 400, это високосный год.)
        Console.Write("Введите год: ");
        int year;
        bool isLeapYear;
        // Год - число
        if (!int.TryParse(Console.ReadLine(), out year))
        {
            Console.WriteLine("Ошибка: некорректный ввод, год - целое число");
        }
        else
        {
            if (year > 0)
            {
                //високосный или нет
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    Console.Write("Введите номер дня в году от 1 до 366: ");
                    isLeapYear = true;
                }
                else
                {
                    Console.Write("Введите номер дня в году от 1 до 365: ");
                    isLeapYear = false;
                }
                ///////
                string input1 = Console.ReadLine();
                // День - число
                if (int.TryParse(input1, out int day1))
                {
                    // Диапозон номера дня
                    if ((isLeapYear) && (day1 < 1 || day1 > 366))
                    {
                        Console.WriteLine("Ошибка: число должно быть в диапазоне от 1 до 366");
                        return;
                    }
                    else if ((!isLeapYear) && (day1 < 1 || day1 > 365))
                    {
                        Console.WriteLine("Ошибка: число должно быть в диапазоне от 1 до 365");
                        return;
                    }

                    DateTime date = new DateTime(year, 1, 1).AddDays(day1 - 1);
                    switch (date.Month)
                    {
                        case 1: Console.WriteLine($"День {day1} соответствует {date.Day} января"); break;
                        case 2: Console.WriteLine($"День {day1} соответствует {date.Day} февраля"); break;
                        case 3: Console.WriteLine($"День {day1} соответствует {date.Day} марта"); break;
                        case 4: Console.WriteLine($"День {day1} соответствует {date.Day} апреля"); break;
                        case 5: Console.WriteLine($"День {day1} соответствует {date.Day} мая"); break;
                        case 6: Console.WriteLine($"День {day1} соответствует {date.Day} июня"); break;
                        case 7: Console.WriteLine($"День {day1} соответствует {date.Day} июля"); break;
                        case 8: Console.WriteLine($"День {day1} соответствует {date.Day} августа"); break;
                        case 9: Console.WriteLine($"День {day1} соответствует {date.Day} сентября"); break;
                        case 10: Console.WriteLine($"День {day1} соответствует {date.Day} октября"); break;
                        case 11: Console.WriteLine($"День {day1} соответствует {date.Day} ноября"); break;
                        case 12: Console.WriteLine($"День {day1} соответствует {date.Day} декабря"); break;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: некорректный ввод, номер дня - целое число");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: год должен быть больше нуля");
            }
        }

    }
}