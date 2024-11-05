using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_2_TTriangle
{
    public class TTriangle
    {
        protected double a, b, c;

        public TTriangle()
        {
            a = 0;
            b = 0;
            c = 0;
        }

        public TTriangle(double a, double b, double c)
        {
            if (IsValidTriangle(a, b, c))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        public static TTriangle ReadFromConsole()
        {
            Console.WriteLine("Введiть довжину сторони a:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введiть довжину сторони b:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введiть довжину сторони c:");
            double c = double.Parse(Console.ReadLine());

            return new TTriangle(a, b, c);
        }

        public double A
        {
            get
            {
                return a;
            }

            set
            {
                if (IsValidTriangle(value, b, c))
                {
                    a = value;
                }

                else
                {
                    throw new ArgumentException("Не вдається створити трикутник");
                }
            }
        }

        public double B
        {
            get
            {
                return b;
            }

            set
            {
                if (IsValidTriangle(a, value, c))
                {
                    b = value;
                }

                else
                {
                    throw new ArgumentException("Не вдається створити трикутник");
                }
            }
        }

        public double C
        {
            get
            {
                return c;
            }

            set
            {
                if (IsValidTriangle(a, b, value))
                {
                    c = value;
                }

                else
                {
                    throw new ArgumentException("Не вдається створити трикутник");
                }
            }
        }

        public bool IsValidTriangle(double a, double b, double c)
        {
            bool isValidate = true;

            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Довжини сторiн повинi бути додатні.");
            }

            if (a + b <= c || b + c <= a || a + c <= b)
            {
                throw new ArgumentException("Трикутника з такими сторонами не існує.");
            }

            return isValidate;
        }

        public TTriangle(TTriangle otherTriangle)
        {
            this.a = otherTriangle.a;
            this.b = otherTriangle.b;
            this.c = otherTriangle.c;
        }

        public double GetPerimeter()
        {
            return a + b + c;
        }

        public double GetArea()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override string ToString()
        {
            return $"Сторони трикутника: {a}, {b}, {c} \nПериметр трикутника: {GetPerimeter()} \nПлоща трикутника: {GetArea()}";
        }

        /*public void WriteToConsole()
        {
            Console.WriteLine($"Периметр трикутника: {GetPerimeter()}");
            Console.WriteLine($"Площа трикутника: {GetArea()}");
        }*/

        /*public void PrintNewSides()
        {
            Console.WriteLine($"Новий трикутник має сторони {a}, {b}, {c}");
        }*/

        public bool IsEqual(TTriangle tr2)
        {
            if (tr2 == null)
            {
                return false;
            }

            double[] triangle1 = {a, b, c};
            double[] triangle2 = { tr2.a, tr2.b, tr2.c };

            Array.Sort(triangle1);
            Array.Sort(triangle2);

            return (triangle1[0] == triangle2[0]) && (triangle1[1] == triangle2[1])
                && (triangle1[2] == triangle2[2]);

            /*return (a == tr2.a && b == tr2.b && c == tr2.c) || (a == tr2.b && b == tr2.a && c == tr2.c)
                || (a == tr2.c && b == tr2.b && c == tr2.a) || (a == tr2.a && b == tr2.c && c == tr2.b)
                || (a == tr2.b && b == tr2.c && c == tr2.a) || (a == tr2.c && b == tr2.a && c == tr2.b);*/
        }

        public static TTriangle operator *(double num, TTriangle tr)
        {
            var temp = new TTriangle(tr.a * num, tr.b * num, tr.c * num);
            return temp;
        }

        public static TTriangle operator *(TTriangle tr, double num)
        {
            var temp = new TTriangle(tr.a * num, tr.b * num, tr.c * num);
            return temp;
        }
    }
}
