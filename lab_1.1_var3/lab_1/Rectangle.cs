using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Rectangle
    {
        private double a, b;

        public double A
        {
            get
            { 
                return a; 
            }

            set
            {
                if (value > 0)
                {
                    a = value;
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
                if (value > 0)
                {
                    b = value;
                }
            }
        }

        public Rectangle (double a, double b)
        {
            if (IsValide(a, b))
            {
                this.a = a;
                this.b = b;
            }
        }

        public double this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return a;
                }

                else if (index == 1)
                {
                    return b;
                }
                
                else throw new IndexOutOfRangeException("Індекс повинен бути 0 або 1.");
            }
            set
            {
                if (index == 0)
                {
                    a = value;
                }

                else if (index == 1)
                {
                    b = value;
                }

                else throw new IndexOutOfRangeException("Індекс повинен бути 0 або 1.");
            }
        }

        public static bool IsValide(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new IndexOutOfRangeException("Сторони повинні бути додатніми");
            }

            return true;
        }

        public static Rectangle ReadFromConsole()
        {
            Console.WriteLine("Введіть довжину сторони a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть довжину сторони b:");
            double b = Convert.ToDouble(Console.ReadLine());

            return new Rectangle(a, b);
        }

        public double GetPerimeter()
        {
            return 2 * (a + b);
        }

        public double GetArea()
        {
            return a * b;
        }

        public override string ToString()
        {
            return $"Периметр: {GetPerimeter()} \nПлоща: {GetArea()}";
        }

    }
}
