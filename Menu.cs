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
            Console.WriteLine("0. Выход");
            Console.WriteLine();

            Console.Write("Введите номер задачи (0-13): ");
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