using System;
namespace LW1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Нужны три стороны треугольника");
            Console.Write("Введите 1-е число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            BoolABC(ref a);
            Console.Write("Введите 2-е число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            BoolABC(ref b);
            Console.Write("Введите 3-е число: ");
            int c = Convert.ToInt32(Console.ReadLine());
            BoolABC(ref c);
            Summa(a, b, ref c);
            Summa(c, b, ref a);
            Summa(c, a, ref b);
            Console.WriteLine($"Стороны треугольника равны {a}, {b}, {c}");

            //равносторонний треугольник
            if (a==b || a==c)
            {
                Console.WriteLine($"Треугольник является равносторонним");
                return;
            }
            int[] l = new int[3] { a, b, c };
            int chek = 0;
            int prov = 0;
            for (int e=0;e<3 ;e++ )
            {
                for (int m=0;m<3 ;m++ )
                {
                    if (l[e] == l[m] || e!=m)
                    {
                        chek++;
                    }
                    if (l[e] != l[m] || e != m)
                    {
                        prov++;
                    }
                }
            }
            //равнобедренный треугольник
            if (chek==2)
            {
                Console.WriteLine($"Треугольник является равнобедренным");
                return;
            }
            //разносторонний треугольник
            if (prov == 6)
            {
                Console.WriteLine($"Треугольник является разносторонним");
            }

        }

        public static void BoolABC(ref int v)
        {
            while (v<=0)
            {
                Console.Write("Вы ввели отрицательное число или 0. Попробуйте ввести заново: ");
                v = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void Summa(int y, int x, ref int z)
        {
            while (z>=y+x)
            {
                Console.Write("Одна из сторон больше суммы двух других. Введите новое значение: ");
                z = Convert.ToInt32(Console.ReadLine());
                BoolABC(ref z);
            }
        }
    }
}
