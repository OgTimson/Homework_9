/*
Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректные данные. Повторите ввод!");
        }
    }

    return result;
}

void WriteNumbers(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    WriteNumbers(num - 1);
}

int num = GetNumber("Введите натуральное число:");
Console.WriteLine($"Натуральные числа в промежутке от {num} до 1:");
WriteNumbers(num);