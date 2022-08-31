// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Clear();
Console.Write("Введи первое целое число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе целое число n: ");
int n = Convert.ToInt32(Console.ReadLine());
  
//сообщение о том, что числа должны быть неотрицательными
if (m<0) Console.WriteLine("числа должны быть положительные! начните заново!!! ");
  else if (n<0) Console.WriteLine("числа должны быть положительные! начните заново!!! ");
else 
{
//решение для функции Акермана
int functionAkkerman = Akkerman(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

  int Akkerman(int m, int n)
  {
    if (m == 0) return n + 1; // A(m,n) = n+1, если m = 0
    else if ((m > 0) && (n == 0)) return Akkerman(m - 1, 1); // = A(m-1,1), если m!=0, n = 0
    else if ((m > 0) && (n > 0)) 
    // = A(m-1,A(m,n-1)), если m>0, n > 0
            return Akkerman(m - 1, Akkerman(m, n - 1)); 
    else return 0;
   }
}
