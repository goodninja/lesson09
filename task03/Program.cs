// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m = InputNumbers("Задайте значение m: ");
int n = InputNumbers("Задайте значение n: ");

// функция Аккермана работает только на малых значениях!

int functionAckermann = AckermannFunction(m, n);

Console.Write($"Функция Аккермана = {functionAckermann} ");

int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AckermannFunction(m - 1, 1);
    else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
