using System;

public static class Menu
{
    public static void ShowMenu()
    {
        int choice;

        do
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Задача 2: Найти максимальное и минимальное числа.");
            Console.WriteLine("2. Задача 4: Найти максимальное число из трех введенных чисел.");
            Console.WriteLine("3. Задача 6: Проверка числа на четность.");
            Console.WriteLine("4. Задача 8: Вывести четные числа от 1 до N.");
            Console.WriteLine("5. Задача 23: Вывести таблицу кубов чисел от 1 до N.");
            Console.WriteLine("6. Задача 10: Вывести вторую цифру трехзначного числа.");
            Console.WriteLine("7. Задача 13: С помощью деления вывести третью цифру заданного числа или сообщить, что третьей цифры нет.");
            Console.WriteLine("8. Задача 15: Принимать на вход цифру, обозначающую день недели, и проверять, является ли этот день выходным.");
            Console.WriteLine("9. Задача 19: Проверка пятизначного числа на палиндромность.");
            Console.WriteLine("10. Задача 21: Нахождение расстояния в 3D пространстве между двумя точками координат.");
            Console.WriteLine("11. Задача 25: Возведение числа A в степень B.");
            Console.WriteLine("12. Задача 27: Сумма цифр числа.");
            Console.WriteLine("13. Задача 29: Сортировка массива по модулю.");
            Console.WriteLine("14. Задача 34: Чётные числа в массиве, заполненном случайными положительными трёхзначными числами.");
            Console.WriteLine("15. Задача 36: Сумма элементов с нечётными индексами в одномерном массиве.");
            Console.WriteLine("16. Задача 38: Разница между максимальным и минимальным элементами массива вещественных чисел.");
            Console.WriteLine("17. Задача 41: Посчитать, сколько чисел больше 0 ввёл пользователь.");
            Console.WriteLine("18. Задача 43: Найти точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
            Console.WriteLine("19. Задача 47: Двумерный массив m×n с вещественными числами (округленными до одного знака).");
            Console.WriteLine("20. Задача 50: Программа, принимающая индексы элемента в двумерном массиве и возвращающая его значение или указание об отсутствии элемента.");
            Console.WriteLine("21. Задача 52: Нахождение среднего арифметического элементов в каждом столбце двумерного массива.");
            Console.WriteLine("0. Выход");
            Console.WriteLine();

            Console.Write("Введите номер задачи (0-21): ");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Program.Task2();
                    break;
                case 2:
                    Program.Task4();
                    break;
                case 3:
                    Program.Task6();
                    break;
                case 4:
                    Program.Task8();
                    break;
                case 5:
                    Program.Task23();
                    break;
                case 6:
                    Program.Task10();
                    break;
                case 7:
                    Program.Task13();
                    break;
                case 8:
                    Program.Task15();
                    break;
                case 9:
                    Program.Task19();
                    break;
                case 10:
                    Program.Task21();
                    break;
                case 11:
                    Program.Task25();
                    break;
                case 12:
                    Program.Task27();
                    break;
                case 13:
                    Program.Task29();
                    break;
                case 14:
                    Program.Task34();
                    break;
                case 15:
                    Program.Task36();
                    break;
                case 16:
                    Program.Task38();
                    break;
                case 17:
                    Program.Task41();
                    break;
                case 18:
                    Program.Task43();
                    break;
                case 19:
                    Program.Task47();
                    break;
                case 20:
                    Program.Task50();
                    break;
                case 21:
                    Program.Task52();
                    break;
                case 0:
                    Console.WriteLine("Программа завершена.");
                    break;
                default:
                    Console.WriteLine("Некорректный выбор. Попробуйте еще раз.");
                    break;
            }
            Console.WriteLine();
        } while (choice !=0);

        Console.ReadLine();
    }
}