// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
Console.WriteLine("выведем все натуральные числа из промежутка от m до n");
//Задаем промежуток
Console.Write("Введи первое целое число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи первое целое число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"в промежутке между числами n={n} и m={m}");
Console.WriteLine("расположены следующие натуральные числа:");
int count=0;
int sum=0;
if (m>n)
for (int i = n; i <= m; i++)
{
    Console.Write($" {i}");
    count++;
    sum=sum+i;
}
else
    for (int i = m; i <= n; i++)
       {
        Console.Write($" {i}");
        count++;
        sum=sum+i;
       } 
Console.WriteLine();
Console.WriteLine($"таких чисел {count} шт");
Console.WriteLine($"сумма этих чисел равно {sum} ");