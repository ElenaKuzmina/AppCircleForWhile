using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCircleForWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            //Дано целое положительное число N
            //вычислить Сумму 1+2+3+...+N

            //входные - число N
            //результат - сумма summa
            //промежуточные - параметр k

            //Console.WriteLine("Задача 1");
            //Console.WriteLine("Введите число N = ");
            //int N = int.Parse(Console.ReadLine()); 
            //int summa = 0;
            //for(int k = 1; k <= N; k++)
            //{
            //    summa = summa + k; //формула накопления суммы
            //}
            //Console.WriteLine($"Сумма = {summa}");
            //Console.ReadKey();

            //Задача 2
            //Вычислить произведение N целых чисел, введенных с клавиатуры

            //Console.WriteLine("Задача2");
            //Console.Write("N=");
            //int N = Convert.ToInt32(Console.ReadLine());
            //long P = 1;
            //int a;
            //for(int i = 0; i < N; i++)
            //{
            //    a = Convert.ToInt32(Console.ReadLine());
            //    P *= a; //накопление произведения P=P*a
            //}
            //Console.WriteLine($"Произведение P={P}");
            //Console.ReadKey();

            //Задача 3
            //Определить, сколько раз в числовой последовательности встречается 
            //заданное число
            Console.WriteLine("Задача 3");
            Console.Write("N=");
            int N = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int a;
            Console.WriteLine("Заданное число z=");
            int z = Convert.ToInt32(Console.ReadLine()); 
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Очередное число a=");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == z)
                    count++; //count = count + 1 или count += 1;
            }
            Console.WriteLine($"Количество заданных чисел = {count}");
            Console.ReadKey();
        }
    }
}
