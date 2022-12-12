//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите положительное число M не более 4: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное число N не более 4: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m < 0 || n < 0 || m > 3 || n > 3) Console.Write("Введено отрицательное число либо число более 4");
else
{
    AkkermanFunction(m, n);
    int result = AkkermanFunction(m, n);
    Console.WriteLine(result); 
}
int AkkermanFunction (int m, int n)
{
    if(m == 0) return n + 1;
    if(m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
    return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}
