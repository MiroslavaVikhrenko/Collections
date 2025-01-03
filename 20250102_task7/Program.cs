namespace _20250102_task7
{
    internal class Program
    {
        /*
         Создать список List<int>, заполнить. 
        Удалить все нечетные элементы списка, вывести на экран коллекцию, используя метод класса String. ???
         */
        static void Main(string[] args)
        {
            List<int> ints = new List<int>(100);

            int count = 1;
            Random rnd = new Random();
            while (count <= 100)
            {
                ints.Add(rnd.Next(0,100));
                count++;
            }
            Console.WriteLine("-------------------Original list-------------------");
            PrintWithColor(ints);

            DeleteEvenElements(ints);
            Console.WriteLine("\n-------------------New list-------------------");
            Print(ints);

            Console.ReadKey();
        }

        public static void DeleteEvenElements(List<int> ints)
        {
            for (int i = 0; i < ints.Count; i++)
            {
                ints.RemoveAt(i);
            }
            
        }

        public static void Print(List<int> ints)
        {
            for (int i = 0;i < ints.Count; i++)
            {
                Console.Write($"{ints[i]}  ");
            }
        }

        public static void PrintWithColor(List<int> ints)
        {
            for (int i = 0; i < ints.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                if (i == ints.Count - 1)
                {
                    Console.Write($"{ints[i]}");
                }
                else
                {
                    Console.Write($"{ints[i]}  ");
                }
                Console.ResetColor();
            }
        }
    }
}
