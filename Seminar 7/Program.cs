using System;

namespace Seminar7
{
    class Program
    {
        static void Main(string[] args)
        {

    // Задача 47. Задайте двумерный массив размером m х n, заполненный случайными вещественными числами.
    // m = 3, n = 4
    // 0,5  7    -2   -0,2
    // 1   -3,3   8   -9,9
    // 8    7,8  -7,1  9   

        //     double [,] GetArrayRealNumbers()
        //     {
        //     Console.WriteLine("Введите количество строк массива: ");
        //     int rows = Convert.ToInt32(Console.ReadLine());

        //     Console.WriteLine("Введите количество столбцов массива: ");
        //     int columns = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine();
            
        //      double [,] matrix = new double [rows, columns];
        //      Random random = new Random();
           
        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //     for (int j = 0; j < matrix.GetLength(1); j++)
        //     {
        //        matrix[i,j] = (double)random.Next(-100, 100) / 10;
        //         Console.Write("{0,5:F1}", matrix[i,j]);
        //     }
        //     Console.WriteLine();
        //     }
        //     return matrix;
        //     }

        //     GetArrayRealNumbers();

            // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
            // и возвращает значение этого элемента или же указание, что такого элемена нет.
            // Например задан массив:
            // 1 4 7 2
            // 5 9 2 3
            // 8 4 2 4
            // 17 -> такого числа в массиве нет

           
             Console.WriteLine("Введите количество строк массива: ");
             int rows = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Введите количество столбцов массива: ");
             int columns = Convert.ToInt32(Console.ReadLine());
            
            // Console.WriteLine("Введите позицию искомого элемента в строке: ");
            // int numberRow = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Введите позицию искомого элемента в столбце: ");
            // int numberColumn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            
            int [,] matrix = new int [rows, columns];
            
                     
            void GetArrayIntegerNumbers(int [,] matrix) 
            {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i,j] = new Random().Next(1,10);
                Console.Write($"{matrix[i,j]} ");
            }
            Console.WriteLine();
            }
            } 
            
            // int FindNumberInArray(int numberRow, int numberColumn)
            // { 
            // int result = 0;
            // if (numberRow > rows || numberColumn > columns)
            // {
               
            //   Console.WriteLine($"Элемента с позицией {numberRow}{numberColumn} в массиве нет");
            // }
            // else   
            // {
            //     Console.WriteLine(matrix[numberRow, numberColumn]);
            //     result = matrix[numberRow, numberColumn];
            // }
            // return result;
            // }
            // Console.WriteLine();          
            
                  
            // GetArrayIntegerNumbers(matrix);
            // FindNumberInArray(numberRow, numberColumn);

            // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
            // Например, задан массив:
            // 1 4 7 2
            // 5 9 2 3
            // 8 4 2 4
            // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

            void MidlleArithmeticValueOfColumns()
            {            
                double result = 0;
                double sum = 0;
                Console.Write($"Среднее арифметическое каждого столбца:");
                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum += matrix[i,j];                  
                }
                    result = sum / rows;
                    Console.Write($" {result};");
                    result = 0;
                    sum = 0;
                }
                Console.WriteLine();                
            }
                
                GetArrayIntegerNumbers(matrix);
                MidlleArithmeticValueOfColumns();
        }
    }
}
