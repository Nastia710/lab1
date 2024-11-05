namespace lab1_2_TTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Перший трикутник:");
            TTriangle triangle1 = TTriangle.ReadFromConsole();

            Console.WriteLine(triangle1);

            Console.WriteLine("\nДругий трикутник:");
            TTriangle triangle2 = TTriangle.ReadFromConsole();
            Console.WriteLine(triangle2);

            Console.WriteLine("\nЧи рiвнi трикутники?");
            Console.WriteLine(triangle1.IsEqual(triangle2));

            Console.WriteLine("\nВведiть число:");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Який трикутник помножити на число {number}?");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    TTriangle triangle3 = triangle1 * number;
                    Console.WriteLine($"\nПерший трикутник, помножено на число {number}:");
                    Console.WriteLine(triangle3);
                    break;

                case 2:
                    TTriangle triangle4 = triangle2 * number;
                    Console.WriteLine($"\nПерший трикутник, помножено на число {number}:");
                    Console.WriteLine(triangle4);
                    break;
            }

            TTrianglePrizm prizm = TTrianglePrizm.ReadFromConsole();
            Console.WriteLine(prizm);
        }
    }
}