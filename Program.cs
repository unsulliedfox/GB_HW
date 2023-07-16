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
            Console.WriteLine("2. Задача 4: Найти максимальное число из трех введенных чисел.");
            Console.WriteLine("3. Задача 6: Проверка числа на четность.");
            Console.WriteLine("4. Задача 8: Вывести четные числа от 1 до N.");
            //Console.WriteLine("5. Задача 23: Вывести таблицу кубов чисел от 1 до N.");
            Console.WriteLine("6. Задача 10: Вывести вторую цифру трехзначного числа.");
            Console.WriteLine("7. Задача 13: С помощью деления вывести третью цифру заданного числа или сообщить, что третьей цифры нет.");
            Console.WriteLine("8. Задача 15: Принимать на вход цифру, обозначающую день недели, и проверять, является ли этот день выходным.");
            Console.WriteLine("0. Выход");
            Console.WriteLine();

            Console.Write("Введите номер задачи (0-8): ");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Task2();
                    break;
                case 2:
                    Task4();
                    break;
                case 3:
                    Task6();
                    break;
                case 4:
                    Task8();
                    break;
                //case 5:
                    //Task23();
                    //break;
                case 6:
                    Task10();
                    break;
                case 7:
                    Task13();
                    break;
                case 8:
                    Task15();
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

        a = 2;
        b = 10;

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

        a = -9;
        b = -3;

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

    static void Task4()
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

        num1 = 44;
        num2 = 5;
        num3 = 78;

        max = num1;

        if (num2 > max)
        {
            max = num2;
        }

        if (num3 > max)
        {
            max = num3;
        }

        Console.WriteLine("num1 = " + num1 + ", num2 = " + num2 + ", num3 = " + num3 + " -> max = " + max);

        num1 = 22;
        num2 = 3;
        num3 = 9;

        max = num1;

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


    static void Task6()
    {
        int number;

        Console.Write("Введите число: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine(number + " -> четное");
        }
        else
        {
            Console.WriteLine(number + " -> нечетное");
        }
    }

    static void Task8()
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

    /*static void Task23()
    {
        int N;

        Console.Write("Введите число N: ");
        N = Convert.ToInt32(Console.ReadLine());

        Console.Write("Таблица кубов чисел от 1 до " + N + ": ");

        for (int i = 1; i <= N; i++)
        {
            int cube = i * i * i;
            Console.Write(cube + " ");
        }

        Console.WriteLine();
    }*/
    static void Task10()
    {
        int number;

        Console.Write("Введите трехзначное число: ");
        number = Convert.ToInt32(Console.ReadLine());

        int secondDigit = (number / 10) % 10;

        Console.WriteLine("Вторая цифра числа: " + secondDigit);
    }
    static void Task13()
    {
        int number;

        Console.Write("Введите число: ");
        number = Convert.ToInt32(Console.ReadLine());

        int thirdDigit = (number / 100) % 10;

        if (thirdDigit != 0)
        {
            Console.WriteLine("Третья цифра числа: " + thirdDigit);
        }
        else
        {
            Console.WriteLine("Третьей цифры нет");
        }
    }
    static void Task15()
    {
        int dayOfWeek;

        Console.Write("Введите цифру, обозначающую день недели: ");
        if (!int.TryParse(Console.ReadLine(), out dayOfWeek) || dayOfWeek < 1 || dayOfWeek > 7)
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите цифру от 1 до 7.");
            return;
        }

        if (dayOfWeek == 6 || dayOfWeek == 7)
        {
            Console.WriteLine("Да, это выходной день");
        }
        else
        {
            Console.WriteLine("Нет, это не выходной день");
        }
    }
}
