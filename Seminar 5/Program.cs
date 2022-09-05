using System;

namespace Seminar5
{
    class Program
    {
        static void Main(string[] args)
        {


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

            // int PositivNumberCount()
            // {
            //     Console.Write("Введите количество чисел в массиве: ");
            //     int n = Convert.ToInt32(Console.ReadLine());
            
            //     int [] mas = new int[n];
            //     int count = 0;

            //     for (int i = 0; i < mas.Length; i++)
            //     {
            //         mas[i] = new Random().Next(100, 1000);
            //         Console.Write(string.Join(", ", mas[i]+ ", "));

            //         if (mas[i] % 2 == 0 ) count++;               
            //     }
            //     Console.WriteLine();
            //     return count;     
            // }             
            //     Console.WriteLine($"Количество четных чисел в массиве равно {PositivNumberCount()}");
             

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
            // int NumberSum()
            // {
            //     Console.Write("Введите количество чисел в массиве: ");
            //     int n = Convert.ToInt32(Console.ReadLine());

            //     Console.Write("Введите минимальное значение элемента в массиве: ");
            //     int minNumber = Convert.ToInt32(Console.ReadLine());

            //     Console.Write("Введите максимальное значение элемента в массиве: ");
            //     int maxNumber = Convert.ToInt32(Console.ReadLine());
            
            //     int [] mas = new int[n];
            //     int sum = 0;

            //     for (int i = 0; i < mas.Length; i++)
            //     {
            //         mas[i] = new Random().Next(minNumber, maxNumber + 1);
            //         Console.Write(string.Join(", ", mas[i]+ ", "));

            //         if ((i % 2 ) != 0 ) sum += mas[i];               
            //     }
            //     Console.WriteLine();
            //     return sum;     
            // }             
            //     Console.WriteLine($"Сумма элементов на нечетных позициях равна {NumberSum()}");


    // Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
    //второй и предпоследний и т.д. Результат запишите в новом массиве.
    // [1 2 3 4 5] -> 5 8 3
    // [6 7 3 6] -> 36 21

            // void NumberProduct()
            // {
            //     Console.Write("Введите количество чисел в массиве: ");
            //     int n = Convert.ToInt32(Console.ReadLine());

            //     Console.Write("Введите минимальное значение элемента в массиве: ");
            //     int minNumber = Convert.ToInt32(Console.ReadLine());

            //     Console.Write("Введите максимальное значение элемента в массиве: ");
            //     int maxNumber = Convert.ToInt32(Console.ReadLine());
            
            //     int [] mas = new int[n];

            //     int new_n = (n+1) / 2;
            //     int [] new_mas = new int[new_n];              
            //     for (int i = 0; i < n; i++)
            //     {
            //         mas[i] = new Random().Next(minNumber, maxNumber + 1);
            //     }
            //     Console.WriteLine(string.Join(", ", mas));
                
            //     for (int i = 0; i < (n/2); i++)
            //     {
            //         new_mas[i] = mas[i] * mas[n - 1 - i];
            //     }
            //     if (n % 2 != 0) new_mas[new_n-1] = mas[new_n-1];
            //     Console.WriteLine(string.Join(", ", new_mas));  
            // }
            // NumberProduct();         



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

            static void DiffMaxMin()
            {
                Console.Write("Введите количество чисел в массиве: ");
                int n = Convert.ToInt32(Console.ReadLine());

                double min = double.MaxValue;

                double max = double.MinValue;
            
                double [] mas = new double[n];
         
                for (int i = 0; i < n; i++)
                {
                    mas[i] = new Random().NextDouble();                  
                    if (mas[i] < min) min = mas[i];
                    if (mas[i] > max) max = mas[i];
                }
                Console.WriteLine(string.Join(", ", mas));
                Console.WriteLine($"Разница между максимальным и минимальным значением массива {max-min}");  
            }
            DiffMaxMin();     
        }

    }
}
