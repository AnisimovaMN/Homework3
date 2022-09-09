using System;

namespace Seminar6
{
    class Program
    {
        static void Main(string[] args)
        {

        // Задача 41. Пользователь вводит с клавиатуры М чисел. Посчитайте сколько чисел больше 0 ввел пользователь.
        // 0, 7, 8, -2, -2 -> 2
        // 1, -7, 567, 89, 223 -> 3
                 
        // Console.Write("Введите количество элементов в массиве: ");
        // int M = Convert.ToInt32(Console.ReadLine());

        // Console.Write($"Введите массив из {M} чисел через пробел: ");
        // string [] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
       
        // int NumberMoreZero()
        // {
        // int count = 0;
        // for (int i = 0; i < M; i++)
        // {
        //     if(int.Parse(array[i]) > 0) count++;
        // }
        // return count;
        // }
        // Console.WriteLine($"Количество чисел больше 0 равно {NumberMoreZero()}");
        
        
        // Задача 43. Напишите программу, которая найдет точку пересечения двух прямых,
        // заданных уравнениями y = k1*x+b1, y = k2*x+b2; значения b1, k1, b2, k2 задаются пользователем.
        // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

        
        
            
        void PointOfIntersection()
        {
        Console.Write("Введите значение b1: ");
        int b1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите коэффициент k1: ");
        int k1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение b2: ");
        int b2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите коэффициент k2: ");
        int k2 = Convert.ToInt32(Console.ReadLine());
 
        double x = ((double)(b2 - b1) / (k1 - k2));
        double y = k1 * x + b1;
        Console.WriteLine($"({x};{y})");
        }

        PointOfIntersection();
        

        }
    }
}