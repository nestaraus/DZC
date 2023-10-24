// // Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int rec(int m, int n)
{
    if (n == m)
        return  m;
    return n +  rec(m, n-1);
}





Console.Write("Введите элемент: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите элемент: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m,n));