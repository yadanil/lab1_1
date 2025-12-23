using System.Net;

class Program
{
    //Задание 1 1
    public double Fraction(double x)
    {
        return Math.Abs(x - (int)x);
    }


    //Задание 1 3
    public int charToNum(char x)
    {
        //Вычитаем код символа '0' из кода символа необходимого числа
        return x - '0';
    }


    //Задание 1 5
    public bool is2Digits(int x)
    {
        //Вернет значение true или false
        return x >= 10 && x <= 99 || x <= -10 && x >= -99;

    }


    //Задание 1 7
    public bool isInRange(int a, int b, int num)
    {
        if (a <= b) 
        { 
            return num >= a && num <= b;
        }
        else
        {
            return num <= a && num >= b;
        }


    }


    //Задание 1 9
    public bool isEqual(int a, int b, int c)
    {
        return a == b && b == c;
    }


    //Задание 2 1
    public int abs(int x)
    {
        return (int)Math.Abs(x);
    }


    //Задание 2 3
    public bool is35(int x)
    {
        return (x % 3 == 0) && (x % 5 == 0);
    }


    //Задание 2 5
    public int max3(int x, int y, int z)
    {
        int max = x;

        if (y > max)
        {
            max = y;
        }

        if (z > max)
        {
            max = z;
        }

        return max;
    }


    //Задание 2 7
    public int sum2(int x, int y)
    {
        if (x + y >= 10 && x + y <= 19)
        {
            return 20;
        }
        else
        {
            return x + y;
        }
        
    }


    //Задание 2 9
    public String day(int x)
    {
        switch (x)
        {
            case 1:
                return "Понедельник";
            case 2:
                return "Вторник";
            case 3:
                return "Среда";
            case 4:
                return "Четверг";
            case 5:
                return "Пятница";
            case 6:
                return "Суббота";
            case 7:
                return "Воскресение";
            default:
                return "Такого дня недели нет";
        }
    }


    //Задание 3 1
    public String listNums(int x)
    {
        if (x < 0)
        {
            return "x не должен быть отрицательным";
        }

        string result = "";

        for (int i = 0; i <= x; i++)
        {
            result += i;

            //Добавление пробелов между числами
            if (x > i) 
            {
                result += " ";
            }
        }

        return result;
    }


    //Задание 3 3
    public String chet(int x)
    {
        if (x < 0)
        {
            return "x не должен быть отрицательным";
        }

        string result = "";

        for (int i = 0; i < x; i = i+2)
        {
            result += i;

            //Добавление пробелов между числами
            if (x > i)
            {
                result += " ";
            }
        }

        return result;
    }


    //Задание 3 5
    public int numLen(long x)
    {
        if (x == 0)
        {
            return 1;
        }

        long number = Math.Abs(x);
        int count = 0;

        while (number > 0)
        {
            number /= 10;
            count++;
        }

        return count;
    }


    //Задание 3 7
    public void square(int x)
    {
        if (x <= 0)
        {
            Console.WriteLine("Размер квадрата должен быть положительным числом");
            return;
        }

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }


    //Задание 3 9
    public void rightTriangle(int x)
    {
        if (x <= 0)
        {
            Console.WriteLine("Размер треугольника должен быть положительным числом");
            return;
        }

        for (int i = 1; i <= x; i++)
        {
            for (int j = 0; j < x - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }


    //Задание 4 1
    public int findFirst(int[] arr, int x)
    {
        //Если список пуст
        if (arr == null || arr.Length == 0)
        {
            return -1;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }

        return -1;
    }


    //Задание 4 3
    public int maxAbs(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            throw new ArgumentException("Массив не может быть пустым");
        }

        int max = Math.Abs(arr[0]);

        for (int i = 0; arr.Length > i; i++)
        {
            if (Math.Abs(arr[i]) > max)
            {
                max = Math.Abs(arr[i]);
            }
        }

        return max;
    }


    //Задание 4 5
    public int[] add(int[] arr, int[] ins, int pos)
    {
        if (arr == null)
        {
            arr = new int[0];
        }

        if (ins == null)
        {
            ins = new int[0];
        }

        //Проверка индекса
        if (pos < 0 || pos > arr.Length)
        {
            //При неверно введеном индексе возвращает исходный массив
            int[] result = new int[arr.Length];
            Array.Copy(arr, result, arr.Length);
            return result;
        }

        //Создание нового массива 
        int[] resultArray = new int[arr.Length + ins.Length];

        //Вставляем часть первого массива до индекса для вставки другого массива
        for (int i = 0; i < pos; i++)
        {
            resultArray[i] = arr[i];
        }

        //Вставка элементов
        for (int i = 0; i < ins.Length; i++)
        {
            resultArray[pos + i] = ins[i];
        }

        //Вставляем оставшуюся часть первого массива
        for (int i = pos; i < arr.Length; i++)
        {
            resultArray[ins.Length + i] = arr[i];
        }

        return resultArray;
    }


    //Задание 4 7
    public int[] reverseBack(int[] arr)
    {
        if (arr == null)
        {
            return new int[0];
        }

        //Создание нового массива 
        int[] resultArray = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            resultArray[i] = arr[arr.Length - i - 1];
        }

        return resultArray;
    }


    //Задание 4 9
    public int[] findAll(int[] arr, int x)
    {
        if (arr == null)
        {
            return new int[0];
        }

        //Счетчик для создания массива нужного размера
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                count++;
            }
        }

        //Создание нового массива 
        int[] resultArray = new int[count];
        int index = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                resultArray[index] = i;
                index++;
            }
            
        }

        return resultArray;
    }

    //Основная программа----------------------------------------------------------------------------------------------
    public static void Main(string[] args)
    {
        Program prog = new Program();

        //Задание 1 1
        Console.WriteLine("Задание 1 1");
        Console.WriteLine();
        Console.WriteLine("Введите число:");

        double q1_x;

        while (!double.TryParse(Console.ReadLine(), out q1_x))
        {
            Console.WriteLine("Неверный формат числа");
        }

        Console.WriteLine("Дробная часть:");

        double result_q1 = prog.Fraction(q1_x);

        Console.WriteLine(result_q1);
        Console.WriteLine();


        //Задание 1 3
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Задание 1 3");
        Console.WriteLine();
        Console.WriteLine("Введите число от 0 до 9:");

        char q3_x;
        string input;

        while (true)
        {
            input = Console.ReadLine();

            if (input != null && input.Length == 1 && char.TryParse(input, out q3_x) && q3_x >= '0' && q3_x <= '9')
                break;
            Console.WriteLine("Это не цифра от 0 до 9");
        }

        Console.WriteLine("Результат преобразования:");
        Console.WriteLine(prog.charToNum(q3_x));
        Console.WriteLine();


        //Задание 1 5
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Задание 1 5");
        Console.WriteLine();
        Console.WriteLine("Введите двухзначное число:");

        int q5_x;

        while (!int.TryParse(Console.ReadLine(), out q5_x))
        {
            Console.WriteLine("Неверный формат числа");
        }

        Console.WriteLine("Двузначное ли число:");
        Console.WriteLine(prog.is2Digits(q5_x));
        Console.WriteLine();


        //Задание 1 7
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Задание 1 7");
        Console.WriteLine();
        Console.WriteLine("Введите первую границу диапазона:");

        int q7_x;

        while (!int.TryParse(Console.ReadLine(), out q7_x))
        {
            Console.WriteLine("Неверный формат числа");
        }

        Console.WriteLine("Введите вторую границу диапазона:");
        int q7_y;

        while (!int.TryParse(Console.ReadLine(), out q7_y))
        {
            Console.WriteLine("Неверный формат числа");
        }

        Console.WriteLine("Введите число:");
        int q7_num;

        while (!int.TryParse(Console.ReadLine(), out q7_num))
        {
            Console.WriteLine("Неверный формат числа");
        }

        Console.WriteLine("Входит ли в диапазон:");
        Console.WriteLine(prog.isInRange(q7_x,q7_y,q7_num));
        Console.WriteLine();


        //Задание 1 9
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Задание 1 9");
        Console.WriteLine();
        Console.WriteLine("Введите первое число:");

        int q9_x;

        while (!int.TryParse(Console.ReadLine(), out q9_x))
        {
            Console.WriteLine("Неверный формат числа");
        }

        Console.WriteLine("Введите второе число:");
        int q9_y;

        while (!int.TryParse(Console.ReadLine(), out q9_y))
        {
            Console.WriteLine("Неверный формат числа");
        }

        Console.WriteLine("Введите третье число:");
        int q9_z;

        while (!int.TryParse(Console.ReadLine(), out q9_z))
        {
            Console.WriteLine("Неверный формат числа");
        }

        Console.WriteLine("Равны ли числа:");
        Console.WriteLine(prog.isEqual(q9_x,q9_y,q9_z));
        Console.WriteLine();


        //Задание 2 1
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Задание 2 1");
        Console.WriteLine();
        Console.WriteLine("Введите число:");

        int q21_x;

        while (!int.TryParse(Console.ReadLine(), out q21_x))
        {
            Console.WriteLine("Неверный формат числа");
        }

        Console.WriteLine("Модуль числа:");
        Console.WriteLine(prog.abs(q21_x));
        Console.WriteLine();


        //Задание 2 3
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Задание 2 3");
        Console.WriteLine();
        Console.WriteLine("Введите число:");

        int q23_x;

        while (!int.TryParse(Console.ReadLine(), out q23_x))
        {
            Console.WriteLine("Неверный формат числа");
        }

        Console.WriteLine("Делится ли на 3 и 5 без остатка:");
        Console.WriteLine(prog.is35(q23_x));
        Console.WriteLine();


        //Задание 2 5
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Задание 2 5");
        Console.WriteLine();
        Console.WriteLine("Введите первое число:");

        int q25_x;

        while (!int.TryParse(Console.ReadLine(), out q25_x))
        {
            Console.WriteLine("Неверный формат числа");
        }

        Console.WriteLine("Введите второе число:");
        int q25_y;

        while (!int.TryParse(Console.ReadLine(), out q25_y))
        {
            Console.WriteLine("Неверный формат числа");
        }

        Console.WriteLine("Введите третье число:");
        int q25_z;

        while (!int.TryParse(Console.ReadLine(), out q25_z))
        {
            Console.WriteLine("Неверный формат числа");
        }

        Console.WriteLine("Максимальное число:");
        Console.WriteLine(prog.max3(q25_x, q25_y, q25_z));
        Console.WriteLine();


        //Задание 2 7
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Задание 2 7");
        Console.WriteLine();
        Console.WriteLine("Введите первое число:");

        int q27_x;

        while (!int.TryParse(Console.ReadLine(), out q27_x))
        {
            Console.WriteLine("Неверный формат числа");
        }

        Console.WriteLine("Введите второе число:");
        int q27_y;

        while (!int.TryParse(Console.ReadLine(), out q27_y))
        {
            Console.WriteLine("Неверный формат числа");
        }

        Console.WriteLine("Сумма чисел:");
        Console.WriteLine(prog.sum2(q27_x, q27_y));
        Console.WriteLine();


        //Задание 2 9
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Задание 2 9");
        Console.WriteLine();
        Console.WriteLine("Введите номер дня недели:");

        int q29_x;

        while (!int.TryParse(Console.ReadLine(), out q29_x))
        {
            Console.WriteLine("Неверный формат числа");
        }

        Console.WriteLine("День недели:");
        Console.WriteLine(prog.day(q29_x));
        Console.WriteLine();


        //Задание 3 1
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Задание 3 1");
        Console.WriteLine();
        Console.WriteLine("Введите число x:");

        int q31_x;

        while (!int.TryParse(Console.ReadLine(), out q31_x))
        {
            Console.WriteLine("Неверный формат числа");
        }

        Console.WriteLine($"Все числа от 0 до {q31_x}");
        Console.WriteLine(prog.listNums(q31_x));
        Console.WriteLine();


        //Задание 3 3
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Задание 3 3");
        Console.WriteLine();
        Console.WriteLine("Введите число:");

        int q33_x;

        while (!int.TryParse(Console.ReadLine(), out q33_x))
        {
            Console.WriteLine("Неверный формат числа");
        }

        Console.WriteLine($"Все четные числа от 0 до {q33_x}");
        Console.WriteLine(prog.chet(q33_x));
        Console.WriteLine();


        //Задание 3 5
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Задание 3 5");
        Console.WriteLine();
        Console.WriteLine("Введите число:");

        long q35_x;

        while (!long.TryParse(Console.ReadLine(), out q35_x))
        {
            Console.WriteLine("Неверный формат числа");
        }

        Console.WriteLine("Количество знаков в числе:");
        Console.WriteLine(prog.numLen(q35_x));
        Console.WriteLine();


        //Задание 3 7
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Задание 3 7");
        Console.WriteLine();
        Console.WriteLine("Введите число:");

        int q37_x;

        while (!int.TryParse(Console.ReadLine(), out q37_x))
        {
            Console.WriteLine("Неверный формат числа");
        }

        prog.square(q37_x);
        Console.WriteLine();


        //Задание 3 9
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Задание 3 9");
        Console.WriteLine();
        Console.WriteLine("Введите число:");

        int q39_x;

        while (!int.TryParse(Console.ReadLine(), out q39_x))
        {
            Console.WriteLine("Неверный формат числа");
        }

        prog.rightTriangle(q39_x);
        Console.WriteLine();


        //Задание 4 1
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Задание 4 1");
        Console.WriteLine();
        Console.WriteLine("Введите число:");
        int q41_x;

        while (!int.TryParse(Console.ReadLine(), out q41_x))
        {
            Console.WriteLine("Неверный формат числа");
        }

        int[] q41_array = {1,2,3,7,2,5,1,3,4,9};

        int q41_res = prog.findFirst(q41_array,q41_x);

        if (q41_res != -1)
        {
            Console.WriteLine($"Индекс: {q41_res}");
        }
        else
        {
            Console.WriteLine("Число не найдено");
        }

        Console.WriteLine();


        //Задание 4 3
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Задание 4 3");
        Console.WriteLine();

        int[] q43_arr = { 1, 2, 3, -7, 2, -5, 1, -3, 4, -9 };

        Console.WriteLine("Наибольшее по модулю число в массиве:");
        Console.WriteLine(prog.maxAbs(q43_arr));

        Console.WriteLine("");

        Console.WriteLine();


        //Задание 4 5
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Задание 4 5");
        Console.WriteLine();

        //Первый массив
        int[] q45_arr = { 1, 2, 3, -7, 2, -5, 1, -3, 4, -9 };

        //Второй массив
        int[] q45_ins = {11, 22, 33, -11};

        Console.WriteLine("Введите индекс:");

        int q45_pos;

        while (!int.TryParse(Console.ReadLine(), out q45_pos))
        {
            Console.WriteLine("Неверный формат числа");
        }

        Console.WriteLine("Итоговый массив:");
        Console.WriteLine("[" + string.Join(", ",prog.add(q45_arr, q45_ins, q45_pos)) + "]");
        Console.WriteLine();


        //Задание 4 7
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Задание 4 7");
        Console.WriteLine();

        
        int[] q47_arr = { 1, 2, 3, -7, 2, -5, 1, -3, 4, -9 };

        Console.WriteLine("Развернутый массив:");
        Console.WriteLine("[" + string.Join(", ", prog.reverseBack(q47_arr)) + "]");

        Console.WriteLine("");

        Console.WriteLine();


        //Задание 4 9
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Задание 4 9");
        Console.WriteLine();

        Console.WriteLine("Введите число для поиска:");

        int q49_x;

        while (!int.TryParse(Console.ReadLine(), out q49_x))
        {
            Console.WriteLine("Неверный формат числа");
        }

        int[] q49_arr = { 1, 2, 3, -7, 2, -5, 1, -3, 4, -9 };

        Console.WriteLine("Все индексы этого числа в массиве:");
        Console.WriteLine("[" + string.Join(", ",prog.findAll(q49_arr, q49_x)) + "]");
        Console.WriteLine();
    }
}