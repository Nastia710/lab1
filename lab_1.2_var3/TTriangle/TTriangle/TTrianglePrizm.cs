using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_2_TTriangle
{
    public class TTrianglePrizm : TTriangle
    {
        private double h;

        public TTrianglePrizm() : base()
        {
            h = 0;
        }

        public TTrianglePrizm(double a, double b, double c, double h) : base(a, b, c)
        {
            if (IsValidH(h))
            this.h = h;
        }

        public new static TTrianglePrizm ReadFromConsole()
        {
            Console.WriteLine("\nВведiть довжину сторони a трикутника, який буде в основi призми:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введiть довжину сторони b трикутника, який буде в основi призми:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введiть довжину сторони c трикутника, який буде в основi призми:");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Введiть висоту призми:");
            double h = double.Parse(Console.ReadLine());

            return new TTrianglePrizm(a, b, c, h);
        }

        public bool IsValidH(double h)
        {
            bool isValidate = true;

            if (h <= 0)
            {
                throw new ArgumentException("Висота повинна бути додатною.");
            }

            return isValidate;
        }

        public double H
        {
            get
            {
                return h;
            }

            set
            {
                if (IsValidH(value))
                h = value;
            }
        }

        public TTrianglePrizm(TTriangle triangle, double height) : base(triangle)
        {
            if (IsValidH(height))
            h = height;
        }

        public double GetVolume()
        {
            return h * GetArea();
        }

        public override string ToString()
        {
            return $"\n{base.ToString()} \nВисота призми: {h} \nОб'єм призми: {GetVolume()}";
        }

        public static TTrianglePrizm operator *(double num, TTrianglePrizm prizm)
        {
            return new TTrianglePrizm(prizm.a, prizm.b, prizm.c, prizm.h * num);
        }

        public static TTrianglePrizm operator *(TTrianglePrizm prizm, double num)
        {
            return new TTrianglePrizm(prizm.a, prizm.b, prizm.c, prizm.h * num);
        }
    }
}
