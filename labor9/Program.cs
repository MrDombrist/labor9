using labor9;
static void Main()
{
    static double f(double x)      //метод для первого и третьего задания
    {
        Random random = new Random();
        int a = random.Next(-50, 50);
        Console.Write("a = " + a+"  ");
        if (x < 0)
        {
            if (x == a)
            {
                throw new DivideByZeroException();
            }
            return x + Math.Pow(Math.Sin(1 / (x - a) + 4), 2);
        }
        else
        {
            if (Math.Abs(x) > Math.Abs(a))
            {
                throw new ABSException("Подкоренное выражение не может быть отрицательным!", Math.Abs(x), Math.Abs(a));
            }
            else if (Math.Abs(x) == Math.Abs(a))
                throw new DivideByZeroException();
            return a * x / Math.Sqrt(a * a - x * x);
        }
    }

    //task 1
    //try
    //{
    //    Console.Write("Введите переменную х: ");
    //    double x=Convert.ToDouble(Console.ReadLine());
    //    Console.WriteLine("f(x) = " + f(x)); 
    //}
    //catch(DivideByZeroException e)
    //{
    //    Console.WriteLine("Ошибка, деление на ноль");
    //}
    //catch (FormatException e)
    //{
    //    Console.WriteLine("Ошибка, введите корректные данные");
    //}
    //catch(ABSException e)
    //{
    //    Console.WriteLine("Ошибка, корень не может быть отрицательным! ");
    //}
    //finally
    //{
    //    Console.WriteLine("Всё прошло");
    //}



    static void f1(int k1, int k2, double[] a)          //метод для ручного введения данных в массив в диапозоне
    {
        if (k1 > k2)
        {
            throw new IntervalException("левая граница не может быть больше правой!",k1,k2);
        }
        if (k1 < 0 && k2 > a.Length - 1)
        {
            throw new IndexOutOfRangeException();
        }
        else
        {
            for (int i = k1; i <= k2; i++)
            {
                Console.WriteLine("Введите " + (i) + " элемент: ");
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
    }    
    static void f2(int k1, int k2, double[] a)   //метод для заполнения массива рандомно в диапозоне
    {
        if (k1 > k2)
        {
            throw new IntervalException("левая граница не может быть больше правой!", k1, k2);
        }
        Random random = new Random();
        if (k1 < 0 && k2 > a.Length - 1)
        {
            throw new IndexOutOfRangeException();
        }
        else
            for (int i = k1; i <= k2; i++)
            {
                a[i] = random.NextDouble();
            }
    }
    //task2(a)
    //try
    //{
    //    Console.WriteLine("Введите размерность массива: ");
    //    int n = Convert.ToInt32(Console.ReadLine());
    //    double[] a = new double[n];
    //    Console.WriteLine("Введите диапозон: ");
    //    int k1 = Convert.ToInt32(Console.ReadLine());
    //    int k2 = Convert.ToInt32(Console.ReadLine());
    //    f1(k1, k2, a);
    //}
    //catch (IndexOutOfRangeException e)
    //{
    //    Console.WriteLine("Индекс вышел из-за границы!");
    //}
    //catch (FormatException e)
    //{
    //    Console.WriteLine("Введен неверный тип данных!");
    //}
    //catch(IntervalException e)
    //{
    //    Console.WriteLine("значение левой границы больше,чем правой!");
    //}


    //task2(b)

    //try
    //{
    //    Console.WriteLine("Введите размерность массива: ");
    //    int n = Convert.ToInt32(Console.ReadLine());
    //    double[] a = new double[n];
    //    Console.WriteLine("Введите диапозон: ");
    //    int k1 = Convert.ToInt32(Console.ReadLine());
    //    int k2 = Convert.ToInt32(Console.ReadLine());
    //    f2(k1, k2, a);
    //}
    //catch (IndexOutOfRangeException e)
    //{
    //    Console.WriteLine("Индекс вышел из-за границы!");
    //}
    //catch (FormatException e)
    //{
    //    Console.WriteLine("Введен неверный тип данных!");
    //}
    //catch (IntervalException e)
    //{
    //    Console.WriteLine("значение левой границы больше,чем правой!");
    //}

    //task3
    double FullLenght(double[] x, double[] y)
    {
        double sum = 0;
        for(int i = 1; i < x.Length; i++)
        {
            sum += Math.Sqrt(Math.Pow(x[i] - x[i - 1], 2) + Math.Pow(y[i] - y[i - 1], 2));
        }
        return sum;
    }
    //try { 
    //    Console.WriteLine("Введите размерность массива: ");
    //    int n = Convert.ToInt32(Console.ReadLine());
    //    double[] x = new double[n];
    //    Console.WriteLine("Введите диапозон: ");
    //    int k1 = Convert.ToInt32(Console.ReadLine());
    //    int k2 = Convert.ToInt32(Console.ReadLine());
    //    f1(k1, k2, x);
    //    f2(0, k1-1, x);
    //    f2(k2+1, n-1, x);
    //    Console.WriteLine();
    //    double[] y = new double[n];
    //    int sum = 0;
    //    for(int i = 0; i < y.Length; i++)
    //    {
    //        y[i] = f(x[i]);
    //        Console.WriteLine("x[{0}] = {2}; \ty[{0}] = {1}   ", i, y[i], x[i]);
    //        if (x[i] + 4 <= y[i] && x[i]>=0&& y[i]>=0&& x[i] <= 4 && y[i] <= 4 || x[i] <= 0 && y[i] >= 0 && x[i] >= -4 && y[i]<=4|| x[i] <= 0 && y[i] <=0 && x[i] >= -4 && y[i] <= -4)
    //        {
    //            sum++;
    //            Console.WriteLine("пара: x и у = {0} \t {1}", x[i], y[i]);
    //        }
    //    }
    //    Console.WriteLine("сумма всех таких точке равна: "+ sum);
    //    Console.WriteLine("Длина кривой равна: " + FullLenght(x,y));
    //}
    //catch (IntervalException e) { Console.WriteLine("Значение левой границы больше правой!"); }
    //catch (IndexOutOfRangeException e) { Console.WriteLine("Индекс вышел из-за границ!"); }
    //catch (ABSException e) { Console.WriteLine("Ошибка, корень не может быть отрицательным! ");}
}
Main();