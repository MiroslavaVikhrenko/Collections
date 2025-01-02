namespace _20250102_task4
{
    internal class Program
    {
        /*
         Сформировать список 100 целых случайных чисел в диапазоне от 1 до 10. 
        Напечатать его. Напечатать статистику – сколько раз встречается каждое число списка.
         */
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();

            int i = 0;
            while (i < 100)
            {
                Random rnd = new Random();
                ints.Add(rnd.Next(0, 10));
                i++;
            }

            Console.WriteLine("Original list");
            Print(ints);

            ints.Sort();
            Console.WriteLine("Sorted list");
            Print(ints);

            Console.WriteLine("List stats");
            PrintStats(ints);

            Console.ReadKey();
        }

        public static void PrintStats(List<int> ints)
        {
            Console.WriteLine("--------------------------------------------");

            int count = 1;
            int temp = ints[0];

            for (int i  = 1; i < ints.Count; i++)
            {
                if (ints[i] == temp)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"Value {ints[i-1]} is present {count} time(s)");
                    count = 1;
                    temp = ints[i];
                }
            }
            Console.WriteLine($"Value {ints[ints.Count - 1]} is present {count} time(s)");
            Console.WriteLine("--------------------------------------------");
        }

        public static void Print(List<int> ints)
        {
            Console.WriteLine("--------------------------------------------");

            for (int i = 0; i < ints.Count; i++)
            {
                if (i ==  ints.Count - 1)
                {
                    Console.Write($"{ints[i]}\n");
                }
                else
                {
                    Console.Write($"{ints[i]} | ");
                }
            }
            Console.WriteLine("--------------------------------------------");
        }
    }
}
