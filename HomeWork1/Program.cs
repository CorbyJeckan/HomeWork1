﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args )
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Title = "HomeWork1";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Здравствуйте!\nПожалуйста,введите пункт и подпункт для выбора домашнего задания.\nДоступные для выбора пункты:\n1.1 - Напишите на C# функцию согласно блок-схеме.\n1.3 - Реализуйте функцию вычисления числа Фибоначчи.");
            string selectednumber = (Console.ReadLine());
            switch (selectednumber)
            {
                case "1.1":
                    {
                        Class1.NumberCheck();
                    }
                    break;


                case "1.3":
                    {
                        Fibonachi.Fibonaccirdy(args);
                    }
                    break;
            }
        }
    }

}
