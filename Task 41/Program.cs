
internal class Program
{
    private static void Main(string[] args)
    {
        void OverNull()
        {
            Console.WriteLine("Введите любые числа, для окончания ввода и начала подсчёта введите стоп-число 123");

            int count = 0;
            int num = 0;


            while (num != 123)

            {
                Console.WriteLine("Введите любое число: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num > 0 && num != 123)
                {
                    count++;

                }
                else if (num == 123)
                {
                    Console.WriteLine($"Введено стоп-число 123. \n" + $"Всего введено {count} значений больше нуля");
                    break;
                }

            }

        }

        OverNull();
    }
}