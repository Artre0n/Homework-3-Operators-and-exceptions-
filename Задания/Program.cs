using System;

public enum DaysOfWeek
{
    понедельник = 1,
    вторник = 2,
    среда = 3,
    четверг = 4,
    пятница = 5,
    суббота = 6,
    воскресенье = 7
}
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
            Console.WriteLine("Последовательность упорядоченная по возрастанию");
        }
        else
        {
            Console.WriteLine("Последовательность нарушена числом под индексом: " + index);
        }
        ////////////////////////////////////////////////////////////////////////////////////////
        
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
                case 6: cardValue = "Шестерка"; break;
                case 7: cardValue = "Семерка"; break;
                case 8: cardValue = "Восьмерка"; break;
                case 9: cardValue = "Девятка"; break;
                case 10: cardValue = "Десятка"; break;
                case 11: cardValue = "Валет"; break;
                case 12: cardValue = "Дама"; break;
                case 13: cardValue = "Король"; break;
                case 14: cardValue = "Туз"; break;
                default: cardValue = "Некорректный номер карты"; break;
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
        //////////////////////////////////////////////////////////////////////////////////////////////

        Console.WriteLine("\nУпражнение 3\n");
        //Напишите программу, которая принимает на входе строку и производит выходные
        //данные в соответствии с таблицей
        string input = Console.ReadLine();
        string output = string.Empty;
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsUpper(input[i]))
            {
                output += char.ToLower(input[i]);
            }
            else
            {
                output += input[i];
            }
        }
        switch(output)
        {
            case "jabroni": Console.WriteLine("Patron Tequila"); break;
            case "school counselor": Console.WriteLine("Anything with Alcohol"); break;
            case "programmer": Console.WriteLine("Hipster Craft Beer"); break;
            case "bike gang member": Console.WriteLine("Moonshine"); break;
            case "politician": Console.WriteLine("Your tax dollars"); break;
            case "rapper": Console.WriteLine("Cristal"); break;
            default: Console.WriteLine("Beer"); break;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////
        
        Console.WriteLine("\nУпражнение 4\n");
        //Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,...,7)
        //выводит на экран его название(понедельник, вторник, ..., воскресенье).
        //Использовать enum.
        int dayOfWeek;
        Console.Write("Введите порядковый номер дня недели от 1 до 7: ");
        try
        {
            dayOfWeek = int.Parse(Console.ReadLine()); 
            
            if (dayOfWeek < 1 || dayOfWeek > 7)
            {
                    throw new ArgumentOutOfRangeException();
            }
            Console.WriteLine($"Название дня недели: {Enum.GetName(typeof(DaysOfWeek), dayOfWeek)}");
          
        }
        catch(FormatException)
        {
            Console.WriteLine("Ошибка: введите целое число");
        }
        catch(ArgumentOutOfRangeException)
        {
            Console.WriteLine("Ошибка: число должно быть в диапазоне от 1 до 7");
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////

        Console.WriteLine("\nУпражнение 5\n");
        //Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента
        //"Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е.прибавить к
        //результату.Вывести на экран сколько кукол в “сумке”.
        string[] store = {"Teddy Bear", "LEGO", "Hello Kitty", "Ball", "Rubik's cube", "Barbie doll", "Car"};
        int bag = 0;
        for (int i = 0; i < store.Length; i++)
        {
            store[i] = store[i].ToLower();
        }
        foreach (string toy in store)
        {
            if (toy == "hello kitty" || toy == "barbie doll")
            {
                bag++;
            }
        }
        Console.WriteLine($"Количество кукол в сумке: {bag}");
    }   
}


    
