// Задача 64: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
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
if (m>n)
for (int i = n; i <= m; i++)
{
    Console.Write($" {i}");
    count++;
}
    
else
    for (int i = m; i <= n; i++)
       {
        Console.Write($" {i}");
        count++;
       } 
Console.WriteLine();
Console.WriteLine($"таких чисел {count} шт");