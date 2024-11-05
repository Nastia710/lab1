namespace lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = Rectangle.ReadFromConsole();

            Console.WriteLine(rect);
        }
    }
}