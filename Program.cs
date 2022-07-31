using System;

namespace ConsolleApp
{
     class Program
     {
        static void Main(string[] args)
        {
            void Zadacha41()
            //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
            {int number0=5;
            int count =0;
            for (int i=0;i<number0;i++)
            {
            Console.WriteLine();
            Console.WriteLine($"введите {i+1}-е число");
            int number1=Convert.ToInt32(Console.ReadLine());
            if(number1>0)count++;
           
            }
            Console.WriteLine($"чисел больше 0: {count}");
            }
            Zadacha41();
        }

        
     }
    
}