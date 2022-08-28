using System;

namespace Seminar3
{
    class Program
    {
        static void Main(string[] args)
        // {
        //     Palindrome();
        // }            
        //Задача 19: Напишите программу, которая принимает на вход пятизначное число
        //и проверяет является ли оно палиндромом.

        // static void Palindrome()
        // {
        // Console.Write("Введите пятизначное число: ");
        // string number = Convert.ToString(Console.ReadLine());
          
        //         if(number[0] == number[4] && number[1] == number[3])
        //         {                
        //             Console.WriteLine($"Число {number} полиндром");
        //         }
        //         else
        //         {
        //             Console.WriteLine($"Число {number} не полиндром");
        //         }
        // }              
                
        // {
        //     Distance();
        // }
        // Задача 21: Напишите программу, которая принимает на вход координаты двух точек
        // и находит расстояние между ними в 3D пространстве.
       
        // static void Distance()
        // {
        // Console.Write("Введите Х1: ");
        // int X1 = Convert.ToInt32(Console.ReadLine());

        // Console.Write("Введите Y1: ");
        // int Y1 = Convert.ToInt32(Console.ReadLine());
        
        // Console.Write("Введите Z1: ");
        // int Z1 = Convert.ToInt32(Console.ReadLine());

        // Console.Write("Введите Х2: ");
        // int X2 = Convert.ToInt32(Console.ReadLine());

        // Console.Write("Введите Y2: ");
        // int Y2 = Convert.ToInt32(Console.ReadLine());

        // Console.Write("Введите Z2: ");
        // int Z2 = Convert.ToInt32(Console.ReadLine());

        // double result = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2)+ Math.Pow((Z2 - Z1), 2));
        // Console.WriteLine($"Distance ={result:f2}");
        // }

        {
            TablCube();
        }
        //Задача 23: Напишите программу, которая принимает на вход число (N)
        //и выдаёт таблицу кубов чисел от 1 до N.

        static void TablCube()
        {
            Console.Write("Введите число: ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console. Write($"{Math.Pow(i, 3)} ");
            }
        }
    }
}
