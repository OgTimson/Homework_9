/*
Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
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

int GetSumNum(int numM, int numN, int sum)
{
    if (numM > numN) return sum;
    else
    {
        sum += numM++;
        return GetSumNum(numM, numN, sum);
    }
}

int numM = GetNumber("Введите натуральное число M:");
int numN = GetNumber("Введите натуральное число N:");
int sum = 0;
Console.WriteLine($"Сумма натуральных чисел в промежутке от {numM} до {numN}:");
Console.WriteLine(GetSumNum(numM, numN, sum));