using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    //Написать программу, вычисляющую число Фибоначчи для заданного значения
    //Рекурсивным способом. Предыдущее число + Предпредыдущее число = Текущее число.
    //Так же сделать через цикл.
    internal class Fibonachi
    {
        static int Fibonacci(int i)
        {
            if (i == 0 || i == 1) return i;
            int x = Fibonacci(i - 1) + Fibonacci(i - 2);
            Console.WriteLine(x);
            return x;
        }

        static public void Fibonaccirdy(string[] args)
        {

            Console.WriteLine("Используем алгоритм с рекурсией? Да/Нет");
            string choice = (Console.ReadLine());
            Console.WriteLine("До какого числа выводить значения Фибоначчи? ");
            int number = int.Parse(Console.ReadLine());
            switch (choice)
            {

                case "Да":
                    {
                        if (number <= 15)
                        {
                            Fibonacci(number);
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели слишком большое число,введите число поменьше. ");
                        }
                    }
                    break;


                case "Нет":
                    {

                        int perv = 1;
                        Console.WriteLine("{0} ", perv);
                        int vtor = 1;
                        Console.WriteLine("{0} ", vtor);
                        int sum = 0;

                        while (number >= sum)
                        {
                            sum = perv + vtor;

                            Console.WriteLine("{0} ", sum);

                            perv = vtor;
                            vtor = sum;
                        }
                    }
                    break;

            }


        }


    }
}
