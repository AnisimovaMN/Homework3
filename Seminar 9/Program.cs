//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""

// Console.WriteLine("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// string NumbersRec(int M, int N)
// {
//     if(M <= N) return $"{M}, " + NumbersRec(M + 1, N);
//     else return String.Empty; 
// }
// Console.WriteLine(NumbersRec(M,N));


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

// Console.WriteLine("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int SumRec(int M, int N)
// {
//     if(M == N) return M;
//     else return M + SumRec(M + 1, N);
// }
// Console.WriteLine(SumRec(M,N));


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число m: ");
uint m = Convert.ToUInt32(Console.ReadLine());

Console.WriteLine("Введите число n: ");
uint n = Convert.ToUInt32(Console.ReadLine());

static uint Akkerman(uint m, uint n)
{
    if (m == 0) return n + 1;
    else if((n == 0) && (m > 0)) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.WriteLine(Akkerman(m,n));

