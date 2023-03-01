/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result >= 0)
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

int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else
    {
        return (AckermannFunction(m - 1, AckermannFunction(m, n - 1)));
    }
}

int m = GetNumber("Введите положительное число m:");
int n = GetNumber("Введите положительное число n:");
Console.Write($"Функция Аккермана A({m},{n}) = ");
Console.WriteLine(AckermannFunction(m, n));