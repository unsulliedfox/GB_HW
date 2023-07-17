using System;

public class Menu
{
    public static void Main()
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

            Console.Clear();

            if (choice >= 1 && choice <= 10)
            {
                Tasks.PerformTask(choice);
            }
            else if (choice != 0)
            {
                Console.WriteLine("Некорректный выбор. Попробуйте еще раз.");
            }

            Console.WriteLine();

        } while (choice != 0);
    }
}