//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 0;
int Amount(int start, int finish, int sum)
{
    if (start > finish) return sum;
    sum += start;
    return Amount(start+1, finish, sum);
}
Amount(m, n, result);

Console.Write(Amount(m, n, result));
