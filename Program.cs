using System;
 
class Program
{
        static void Main()
        {
            Menu.ShowMenu();
        }

    public static void Task2()
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

    public static void Task4()
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


    public static void Task6()
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

    public static void Task8()
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

    public static void Task23()
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
    }

    public static void Task10()
    {
        int number;

        Console.Write("Введите трехзначное число: ");
        number = Convert.ToInt32(Console.ReadLine());

        int secondDigit = (number / 10) % 10;

        Console.WriteLine("Вторая цифра числа: " + secondDigit);
    }
    public static void Task13()
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
    public static void Task15()
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

    public static void Task19()
    {
        int number;

        Console.Write("Введите пятизначное число: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (IsPalindrome(number))
        {
            Console.WriteLine("Да, число является палиндромом");
        }
        else
        {
            Console.WriteLine("Нет, число не является палиндромом");
        }
    }

    static bool IsPalindrome(int number)
    {
        string numberString = number.ToString();
        int length = numberString.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (numberString[i] != numberString[length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }

    public static void Task21()
    {
        Console.WriteLine("Введите координаты точки A:");
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());
        double z1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координаты точки B:");
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());
        double z2 = Convert.ToDouble(Console.ReadLine());

        double distance = CalculateDistance(x1, y1, z1, x2, y2, z2);
        Console.WriteLine("Расстояние между точками A и B: " + distance.ToString("F2"));
    }

    static double CalculateDistance(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        double deltaX = x2 - x1;
        double deltaY = y2 - y1;
        double deltaZ = z2 - z1;

        double distanceSquared = deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ;
        double distance = Math.Sqrt(distanceSquared);

        return distance;
    }
    public static void Task25()
    {
        Console.Write("Введите число A: ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        int result = 1;

        for (int i = 1; i <= B; i++)
        {
            result *= A;
        }

        Console.WriteLine("Результат: " + result);
        Console.ReadLine();
    }
    public static void Task27()
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        while (number != 0)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }

        Console.WriteLine("Сумма цифр: " + sum);
        Console.ReadLine();
    }
    public static void Task29()
    {
        int[] array = new int[] { -2, 1, 7, 5, 19 };

        Array.Sort(array, (a, b) => Math.Abs(a).CompareTo(Math.Abs(b)));

        Console.WriteLine("Отсортированный массив: " + string.Join(", ", array));
        Console.ReadLine();
    }
  
}
