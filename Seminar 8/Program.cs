using System;

namespace Seminar7
{
    class Program
    {
        static void Main(string [] args)
        {

    // Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
    // каждой строки двумерного массива.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4   
    // В итоге получается вот такой массив:
    // 7 4 2 1
    // 9 5 3 2
    // 8 4 4 2

            // Console.WriteLine("Введите количество строк массива: ");
            // int rows = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Введите количество столбцов массива: ");
            // int columns = Convert.ToInt32(Console.ReadLine());
            
            // Console.WriteLine();
            
            // int [,] matrix = new int [rows, columns];         
                     
            // void GetArray(int [,] matrix) 
            // {
            //     for (int i = 0; i < matrix.GetLength(0); i++)
            //     {
            //         for (int j = 0; j < matrix.GetLength(1); j++)
            //         {
            //             matrix[i,j] = new Random().Next(1,10);
            //             Console.Write($"{matrix[i,j]} ");
            //         }
            //         Console.WriteLine();
            //     }
            //     Console.WriteLine();
            // } 

            // void SortRowArray(int [,] matrix) 
            // {
            //     for (int i = 0; i < matrix.GetLength(0); i++)
            //     {
            //         for (int j = 0; j < matrix.GetLength(1); j++)
            //         {
            //             for (int k = j + 1; k < matrix.GetLength(0); k++)
            //             {
            //                 if (matrix[i,j] < matrix[i,k])
            //                 {
            //                     int b = matrix[i,j];
            //                     matrix[i,j] = matrix[i,k];
            //                     matrix[i,k] = b;
            //                 }
            //             }
            //         }
            //     }
            // }
            // void PrintArray(int [,] matrix)
            // {
            //   for (int i = 0; i < matrix.GetLength(0); i++)
            //   {
            //     for (int j = 0; j < matrix.GetLength(1); j++)
            //     {
            //       Console.Write($"{matrix[i,j]} ");
            //     }
            //     Console.WriteLine();
            //   }
            // }
            
            // GetArray(matrix);
            // SortRowArray(matrix);
            // PrintArray(matrix);

    // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 5 2 6 7
    // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

            // Console.WriteLine("Введите количество строк массива: ");
            // int rows = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Введите количество столбцов массива: ");
            // int columns = Convert.ToInt32(Console.ReadLine());
            
            // Console.WriteLine();
            
            // int [,] matrix = new int [rows, columns];         
                     
            // void GetArray(int [,] matrix) 
            // {
            //     for (int i = 0; i < matrix.GetLength(0); i++)
            //     {
            //         for (int j = 0; j < matrix.GetLength(1); j++)
            //         {
            //             matrix[i,j] = new Random().Next(1,10);
            //             Console.Write($"{matrix[i,j]} ");
            //         }
            //         Console.WriteLine();
            //     }
            //     Console.WriteLine();
            // } 

            // void FindRowMinSum(int [,] matrix)
            // {            
            //     int minSum = 1000;
            //     int n = 0;
            //     for (int i = 0; i < matrix.GetLength(0); i++)
            //     {
            //         int sum = 0;

            //     for (int j = 0; j < matrix.GetLength(1); j++)
            //     {
            //         sum += matrix[i,j];                  
            //     }
            //     if (sum < minSum)
            //         {
            //             minSum = sum;
            //             n = i;
            //         }  
            //     }
            //     Console.Write($" Строка с наименьшей суммой {n+1};");
            //     Console.WriteLine();                
            // }
            // GetArray(matrix);
            // FindRowMinSum(matrix);

        // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
        // Например, даны 2 матрицы:
        // 2 4 | 3 4
        // 3 2 | 3 3
        // Результирующая матрица будет:
        // 18 20
        // 15 18
            
        //     Console.WriteLine("Введите размерность первой матрицы: ");
        //     int[,] matrixA = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
        //     for (int i = 0; i < matrixA.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < matrixA.GetLength(1); j++)
        //         {
        //             Console.Write("A[{0},{1}] = ", i, j);
        //             matrixA[i, j] = Convert.ToInt32(Console.ReadLine());
        //         }
        //     }
        //     Console.WriteLine("Введите размерность второй матрицы: ");
        //     int[,] matrixB = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
        //     for (int i = 0; i < matrixB.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < matrixB.GetLength(1); j++)
        //         {
        //             Console.Write("B[{0},{1}] = ", i, j);
        //             matrixB[i, j] = Convert.ToInt32(Console.ReadLine());
        //         }
        //     }
            
        //     Console.WriteLine("\nМатрица A:");
        //     PrintArray(matrixA);
        //     Console.WriteLine("\nМатрица B:");
        //     PrintArray(matrixB);
        //     Console.WriteLine("\nРезультирующая матрица будет:");
        //     int[,] matrix = MatrixProduct(matrixA, matrixB);
        //     PrintArray(matrix);
 
        
        // int [,] MatrixProduct(int [,] matrixA, int [,] matrixB)
        // {
        //         int aRows = matrixA.GetLength(0);
        //         int aColumns = matrixA.GetLength(1);
        //         int bRows = matrixB.GetLength(0);
        //         int bColumns = matrixB.GetLength(1);
        //         int temp = 0;
        //         int [,] matrix = new int[aRows, bColumns];
                                
        //         if(aColumns != bRows) throw new Exception("Матрицы нельзя перемножить");
                    
        //             for (int i = 0; i < aRows; i++)
        //             {
        //                     for (int j = 0; j < bColumns; j++)
        //                     {
        //                         temp = 0;
        //                         for (int k = 0; k < aColumns; k++)
        //                         {
        //                             temp += matrixA[i,k] * matrixB[k,j];
        //                         }
        //                         matrix[i,j] = temp;
        //                     }
        //             }
        //             return matrix;
        // }  
            
        // void PrintArray(int[,] matrix)
        // {
        //     for (int i = 0; i < matrix.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < matrix.GetLength(1); j++)
        //         {
        //             Console.Write("{0} ", matrix[i, j]);
        //         }
        //         Console.WriteLine();
        //     }
        // }

        // Задача 60.Сформируйте трехмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
        // которая будет построчно выводить массив, добавляя индексы каждого элемента.
        // Массив размером 2х2х2
        // 66(0,0,0) 25(0,1,0)
        // 34(1,0,0) 41(1,1,0)
        // 27(0,0,1) 90(0,1,1)
        // 26(1,0,1) 55(1,1,1)

            int arraySizeX = 2;
            int arraySizeY = 2;
            int arraySizeZ = 2;
            int minNumber = 10;
            int maxNumber = 99;
            int [,,]Array = new int [arraySizeX, arraySizeY, arraySizeZ];
            Console.Clear();

            FillArrayRandomNumber(Array, minNumber, maxNumber);
            PrintArrayWithIndex(Array);

            void FillArrayRandomNumber(int [,,] Array, int minNumber, int maxNumber)
            {
                Random rand = new Random();
                for (int i = 0; i < Array.GetLength(0); i++)
                 {
                     for (int j = 0; j < Array.GetLength(1); j++)
                     {
                        for (int k = 0; k < Array.GetLength(2); k++)
                        {
                            while (Array[i,j,k] == 0)
                            {
                                int number = rand.Next(minNumber, maxNumber + 1);
                                if(IsNumberInArray(Array, number) == false)
                                {
                                    Array[i,j,k] = number;
                                }
                            }
                        }
                     }
                 }
            }

            bool IsNumberInArray(int [,,] Array, int number)
            {
                for (int i = 0; i < Array.GetLength(0); i++)
                {
                     for (int j = 0; j < Array.GetLength(1); j++)
                    {
                        for (int k = 0; k < Array.GetLength(2); k++)
                        {
                            if(Array[i,j,k] == number) return true;
                        }
                    }
                }
                return false;
            }

            void PrintArrayWithIndex(int [,,] Array)
            {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    for (int k = 0; k < Array.GetLength(2); k++)
                    {
                        Console.Write(Array[i,j,k]);
                        Console.Write("({0},{1},{2})\t", i,j,k);
                    }
                    Console.WriteLine();
                }
            }
            }
        }
    }
}
