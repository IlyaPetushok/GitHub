using System;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=0, b=0,c=0;
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Возведение в степень");
            Console.WriteLine("6. Найти факториал");
            Console.WriteLine("7. Выход");
            while(c!=9)
            {
                Console.Write("Выберите операцию:");
                int n = int.Parse(Console.ReadLine());
                c = n + 2;
                if (n >= 1 && n <= 4)
                {

                    Console.Write("Введите 1-ое число:");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Введите 2-ое число:");
                    b = double.Parse(Console.ReadLine());
                }
                switch (n)
                {
                    case 1: Console.WriteLine("Ответ:" + (a + b)); break;
                    case 2: Console.WriteLine("Ответ:" + (a - b)); break;
                    case 3: Console.WriteLine("Ответ:" + (a * b)); break;
                    case 4:
                        while (b == 0)
                        {
                            if (b == 0) { Console.WriteLine("На 0 делить нельзя!!!"); }
                            Console.Write("Введите заново 2 число:");
                            b = double.Parse(Console.ReadLine());
                        }
                        if(b!=0) { Console.WriteLine("Ответ:" + (a / b)); };
                        break;
                    case 5:
                        Console.Write("Введите число:");
                        double r = double.Parse(Console.ReadLine());
                        Console.Write("Введите степень:");
                        double k = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ:" + Math.Pow(r, k));
                        break;
                    case 6:
                        Console.Write("Введите число:");
                        int fact = int.Parse(Console.ReadLine());
                        while (fact < 0) 
                        {
                            Console.WriteLine("Введите заново число:");
                            fact = int.Parse(Console.ReadLine()); 
                        }
                        int sum = 1;
                        for (int i = 1; i < fact; i++)
                        {
                            sum += sum * i;
                        }
                        Console.WriteLine("Ответ:" + sum);
                        break;
                }
            }
            Console.WriteLine("Был осуществлён выход!");
        }
    }
}
