using System;

public class MainClass
{
    public static void Main()
    {
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
    }
}

    
