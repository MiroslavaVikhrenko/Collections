namespace _20250102_task5
{
    internal class Program
    {
        /*
         Используя рекурсию, найдите в массиве максимальное число и верните его. Продумайте эффективный алгоритм.
         */
        static void Main(string[] args)
        {
            int[] ints = new int[100];

            int i = 0;
            Random rnd = new Random();
            while (i < 100)
            {
                ints[i] = rnd.Next(-99,100);
                i++;
            }

            Console.WriteLine("Original array");
            Print(ints);

            Console.WriteLine($"Max is {FindMax(ints, 0, 0)}");

            Console.ReadKey();
        }

        private static int FindMax(int[] array, int index, int currentMax = 0)
        {
            if (index == 0)
            {
                currentMax = array[0];
            }

            if (index == array.Length)
            {
                return currentMax;
            }
            else
            {
                currentMax = Math.Max(currentMax, array[index]);
                return FindMax(array, index + 1, currentMax);
            }
        }
        public static void Print(int[] ints)
        {
            Console.WriteLine("--------------------------------------------");

            for (int i = 0; i < ints.Length; i++)
            {
                if (i == ints.Length - 1)
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
