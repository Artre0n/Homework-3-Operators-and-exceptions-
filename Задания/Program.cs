using System;

public class MainClass
{
    public static void Main()
    {
        /*
        Console.WriteLine("Упражнение 1\n");
        //Дана последовательность из 10 чисел. Определить, является ли эта последовательность
        //упорядоченной по возрастанию.В случае отрицательного ответа определить
        //порядковый номер первого числа, которое нарушает данную последовательность.
        //Использовать break.
        int[] numbers = new int[10];
        Console.WriteLine("Введите 10 чисел столбиком");
        for (int i = 0; i < numbers.Length; i++)
        {
            if(!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.WriteLine("Ошибка: некорректный ввод");
                break;
            }
        }
        int index = -1;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > numbers[i + 1])
            {
                index = i + 1;
                break;
            }
        }

        if (index == -1)
        {
            Console.WriteLine("Последовательность упорядоченная по возрастанию.");
        }
        else
        {
            Console.WriteLine("Последовательность нарушена числом под индексом: " + index);
        }
        ////////////////////////////////////////////////////////////////////////////////////////
        */
        Console.WriteLine("\nУпражнение 2\n");
        //Игральным картам условно присвоены следующие порядковые номера в зависимости от
        //их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
        //Порядковые номера остальных карт соответствуют их названиям(«шестерка»,
        //«девятка» и т.п.).По заданному номеру карты k(6 <= k <= 14) определить достоинство
        //соответствующей карты. Использовать try-catch-finally.
        Console.Write("Введите номер карты от 6 до 14: ");
        try
        {
            int sequenceNumber = int.Parse(Console.ReadLine());

            if (sequenceNumber < 6 || sequenceNumber > 14)
            {
                throw new ArgumentOutOfRangeException();
            }

            string cardValue;

            switch (sequenceNumber)
            {
                case 6:
                    cardValue = "Шестерка";
                    break;
                case 7:
                    cardValue = "Семерка";
                    break;
                case 8:
                    cardValue = "Восьмерка";
                    break;
                case 9:
                    cardValue = "Девятка";
                    break;
                case 10:
                    cardValue = "Десятка";
                    break;
                case 11:
                    cardValue = "Валет";
                    break;
                case 12:
                    cardValue = "Дама";
                    break;
                case 13:
                    cardValue = "Король";
                    break;
                case 14:
                    cardValue = "Туз";
                    break;
                default:
                    cardValue = "Некорректный номер карты";
                    break;
            }

            Console.WriteLine($"Достоинство карты с номером {sequenceNumber}: {cardValue}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введите целое число");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Ошибка: некорректное значение карты");
        }
        finally
        {
            Console.WriteLine("Программа завершена");
        }
    }
}


    
