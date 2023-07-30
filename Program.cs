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
    public static void Task34()
    {
        // Создаем генератор случайных чисел
        Random random = new Random();

        // Создаем массив для хранения случайных трехзначных чисел
        int[] numbers = new int[10]; // Можете изменить размер массива на сколько вам нужно

        // Заполняем массив случайными трехзначными числами
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(100, 1000); // Генерируем случайное трехзначное число от 100 до 999
        }

        // Показываем элементы массива
        Console.WriteLine("Массив случайных трехзначных чисел:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        // Считаем количество четных чисел в массиве
        int countEvenNumbers = 0;
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                countEvenNumbers++;
            }
        }

        // Показываем количество четных чисел
        Console.WriteLine("\nКоличество четных чисел в массиве: " + countEvenNumbers);

        Console.ReadLine();
    }
    public static void Task36()
    {
        // Задаем размер массива
        int size = 10;

        // Создаем массив и заполняем случайными числами
        int[] array = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100); // случайное число от 0 до 99
        }

        // Выводим массив на экран
        Console.WriteLine("Массив:");
        PrintArray(array);

        // Находим сумму элементов с нечетными индексами
        int sum = SumOfElementsWithOddIndex(array);

        // Выводим результат на экран
        Console.WriteLine("Сумма элементов с нечетными индексами: " + sum);
    }

    // Метод для вывода массива на экран
    static void PrintArray(int[] arr)
    {
        foreach (var element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    // Метод для нахождения суммы элементов с нечетными индексами
    static int SumOfElementsWithOddIndex(int[] arr)
    {
        int sum = 0;
        for (int i = 1; i < arr.Length; i += 2)
        {
            sum += arr[i];
        }
        return sum;
    }
    public static void Task38()
    {
        // Создаем массив с вещественными числами
        double[] array = { 3.21, 7.04, 22.93, -2.71, 78.24 };

        // Находим максимальный и минимальный элементы
        double max = array[0];
        double min = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }

            if (array[i] < min)
            {
                min = array[i];
            }
        }

        // Вычисляем разницу между максимальным и минимальным элементами
        double diff = Math.Round(max - min, 2);

        // Выводим результат на экран
        Console.WriteLine("Массив:");
        PrintArray(array);

        Console.WriteLine("Максимальный элемент: " + max);
        Console.WriteLine("Минимальный элемент: " + min);
        Console.WriteLine("Разница между максимальным и минимальным элементами: " + diff);
    }
    // Метод для вывода массива на экран
    static void PrintArray(double[] arr)
    {
        foreach (var element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
    public static void Task41()
    {
        Console.Write("Введите количество чисел (M): ");
        int M = int.Parse(Console.ReadLine());

        int count = 0;

        for (int i = 0; i < M; i++)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                count++;
            }
        }

        Console.WriteLine("Количество чисел больше 0: " + count);
    }
    public static void Task43()
    {
        Console.Write("Введите значение k1: ");
        double k1 = double.Parse(Console.ReadLine());

        Console.Write("Введите значение b1: ");
        double b1 = double.Parse(Console.ReadLine());

        Console.Write("Введите значение k2: ");
        double k2 = double.Parse(Console.ReadLine());

        Console.Write("Введите значение b2: ");
        double b2 = double.Parse(Console.ReadLine());

        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine("Точка пересечения: (" + x + "; " + y + ")");
    }
    public static void Task47()
    {
        int m = 3;
        int n = 4;
        double[,] matrix = new double[m, n];
        Random random = new Random();

        // Заполнение двумерного массива случайными вещественными числами и округление до одного знака
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = Math.Round(random.NextDouble() * 20 - 10, 1);
            }
        }

        // Вывод двумерного массива
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    public static void Task50()
    {
        int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

        Console.Write("Введите номер строки: ");
        int rowIndex = Convert.ToInt32(Console.ReadLine()) - 1;

        Console.Write("Введите номер столбца: ");
        int columnIndex = Convert.ToInt32(Console.ReadLine()) - 1;

        if (rowIndex >= 0 && rowIndex < array.GetLength(0) && columnIndex >= 0 && columnIndex < array.GetLength(1))
        {
            int element = array[rowIndex, columnIndex];
            Console.WriteLine("Элемент с заданными индексами: " + element);
        }
        else
        {
            Console.WriteLine("Такого элемента не существует.");
        }
    }
    public static void Task52()
    {
        int[,] array = { 
            { 1, 4, 7, 2 }, 
            { 5, 9, 2, 3 }, 
            { 8, 4, 2, 4 }
         };
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        double[] columnSums = new double[columns];

        // Считаем суммы элементов в каждом столбце
        for (int j = 0; j < columns; j++)
        {
            for (int i = 0; i < rows; i++)
            {
                columnSums[j] += array[i, j];
            }
        }

        // Вычисляем среднее арифметическое для каждого столбца
        double[] columnAverages = new double[columns];
        for (int j = 0; j < columns; j++)
        {
            columnAverages[j] = columnSums[j] / rows;
        }

        // Выводим результат
        Console.WriteLine("Среднее арифметическое каждого столбца:");
        for (int j = 0; j < columns; j++)
        {
            Console.Write(Math.Round(columnAverages[j], 1) + " ");
        }
        Console.WriteLine();
    }
  
}
