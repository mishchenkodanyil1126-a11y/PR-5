using System.Text;

namespace PR_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Console.WriteLine("Введіть кількість елементів: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    if (i % 3 == 0)
                    {
                        sum -= i;
                    }
                    else
                    {
                        sum += i;
                    }
                }
                Console.WriteLine($"Сума чисел дорівнює {sum}");
            }
        }
    }
}
