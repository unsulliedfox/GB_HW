// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Задача 2: Найти максимальное и минимальное числа.");
            Console.WriteLine("2. Задача 3: Найти максимальное число из трех введенных чисел.");
            Console.WriteLine("3. Задача 4: Проверка числа на четность.");
            Console.WriteLine("4. Задача 5: Вывести четные числа от 1 до N.");
            Console.WriteLine("0. Выход");
            Console.WriteLine();

            Console.Write("Введите номер задачи (0-4): ");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Task2();
                    break;
                case 2:
                    Task3();
                    break;
                case 3:
                    Task4();
                    break;
                case 4:
                    Task5();
                    break;
                case 0:
                    Console.WriteLine("Программа завершена.");
                    break;
                default:
                    Console.WriteLine("Некорректный выбор. Попробуйте еще раз.");
                    break;
            }

            Console.WriteLine();
        } while (choice != 0);

        Console.ReadLine();
    }

    static void Task2()
    {
        int a = 5;
        int b = 7;

        int max, min;

        if (a > b)
        {
            max = a;
            min = b;
        }
        else
        {
            max = b;
            min = a;
        }

        Console.WriteLine("a = " + a + "; b = " + b + " -> max = " + max);
        Console.WriteLine("a = " + a + "; b = " + b + " -> min = " + min);
    }

    static void Task3()
    {
        int num1 = 2;
        int num2 = 3;
        int num3 = 7;

        int max = num1;

        if (num2 > max)
        {
            max = num2;
        }

        if (num3 > max)
        {
            max = num3;
        }

        Console.WriteLine("num1 = " + num1 + ", num2 = " + num2 + ", num3 = " + num3 + " -> max = " + max);
    }

    static void Task4()
    {
        int number;

        Console.Write("Введите число: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine(number + " -> да");
        }
        else
        {
            Console.WriteLine(number + " -> нет");
        }
    }

    static void Task5()
    {
        int n;

        Console.Write("Введите число N: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Четные числа от 1 до " + n + ": ");

        for (int i = 2; i <= n; i += 2)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }
}
