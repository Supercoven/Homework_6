
internal class Program
{
    private static void Main(string[] args)
    {
        void CrossPoint(double b1, double k1, double b2, double k2)
        {

            if (k1 != k2)
            {
                double x = (b1 - b2) / (k2 - k1);
                double y = k1 * x + b1;

                Console.Write($"Точка пересечения ({x}; {y})");
            }
            else
            {
                Console.Write("Точка пересечения отсутствует");
            }

        }
        Console.WriteLine("Дано уравненение: y = k1 * x + b1, y = k2 * x + b2, введите данные чтобы найти точку пересечения двух прямых");
        Console.WriteLine("Введите b1: ");
        double b1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите k1: ");
        double k1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите b2: ");
        double b2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите k2: ");
        double k2 = Convert.ToInt32(Console.ReadLine());

        CrossPoint(b1, k1, b2, k2);
    }
}