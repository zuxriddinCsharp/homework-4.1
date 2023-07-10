namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int countMax = 0;
            int a = 1;
            do
            {
                Console.WriteLine("Enter number:");
                int number = int.Parse(Console.ReadLine());
                if (number == 0) break;
                else if (a == number)
                {
                    count++;
                }
                else
                {
                    if (countMax < count)
                    {
                        countMax = count;
                    }
                    a = number;
                    count = 1;
                }
            }
            while (true);
            if (countMax < count)
            {
                countMax = count;
            }
            Console.WriteLine($"result {countMax} ");
        }
    }
}