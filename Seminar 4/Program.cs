using System;

namespace Seminar4
{
    class Program
    {
        static void Main(string[] args)
        {
//Задача 25. Напишите цикл, который принимает на вход два числа (А и В) 
//и возводит число А в натуральную степень В.

        //     Console.Write("Введите число: ");
        //     int numberA = int.Parse(Console.ReadLine());

        //     Console.Write("Введите степень числа: ");
        //     int numberB = int.Parse(Console.ReadLine());

        //     int NumberInDegree()
        //     {

        //         int result = 1;

        //         for (int i = 0; i < numberB; i++)
        //         {
        //             result *= numberA;
        //         }
        //         return result;
        //     }

            
        //     Console.WriteLine($"Число {numberA} в степени {numberB} равно {NumberInDegree()}");            
        // }

// Задача 27. Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

        //     Console.Write("Введите число: ");
        //     int number = int.Parse(Console.ReadLine());
        
        //     int SumNumber(int number)
        //     {
        //         int sum = 0;
        //         while(number > 0)
        //         {
        //             sum += number % 10;
        //             number /= 10;
        //         }
        //         return sum;
        //     }

        //      Console.WriteLine($"Сумма цифр числа {number} равна {SumNumber(number)}");
        // }

            
                        
        
// Задача 29. Напишите программу, которая задает массив из введенного числа и выводит их на экран. 
//Пользователь вводит число элементов в массиве, минимальное и максимальное значение. 
//Надо заполнить массив рандомными данными от минимального до максимального значения. 
// Использовать метод, который возвращает массив.

        Console.Write("Введите число элементов массива: ");
        int count = int.Parse(Console.ReadLine());

        Console.Write("Введите минимальное значение элемента в массиве: ");
        int minNumber = int.Parse(Console.ReadLine());

        Console.Write("Введите максимальное значение элемента в массиве: ");
        int maxNumber = int.Parse(Console.ReadLine());
        
        int []mas = new int [count];
        
        int PrintArray(int []array)
        {
        
        for (int i = 0; i < count; i++)
            {
                array[i] = new Random().Next(minNumber, maxNumber + 1);
                Console.Write(string.Join(" ", array[i] + " "));
            }
        return mas[count-1];
        }
        
        PrintArray(mas);
        Console.WriteLine();
        }
    }
}