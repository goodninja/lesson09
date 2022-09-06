// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

int m = 0, n = 0;
do
{
    m = InputNumbers("Задайте число M: ");
    n = InputNumbers("Задайте число N: ");
}
while (m >= n);
System.Console.WriteLine($"Список чётных натуральных чисел от {m} до {n}: ");
FindEvenNaturalNumbers(m, n);

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    if (output < 1)
    {
        throw new Exception("Введите, пожалуйста, натуральное число");
    }
    else return output;
}


void FindEvenNaturalNumbers(int a, int b)
{
    if (a > b) return;
    if (a % 2 != 0)
    {
        a++;
    }
    System.Console.Write(a + " ");
    FindEvenNaturalNumbers(a + 2, b);
}