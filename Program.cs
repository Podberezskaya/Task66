// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

int rec (int m, int n)
{
  if (m == n)
  {
    return n;
  }
  return (m + n) * (n - m +1) /2;
}
Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(rec (m,n));