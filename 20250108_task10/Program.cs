namespace _20250108_task10
{
    internal class Program
    {
        /*
         Дана очередь, состоящая из N целых чисел. Удалите все элементы, равные первому.
         */
        static void Main(string[] args)
        {
            try
            {
                Queue<int> queue = new Queue<int>();
                Random rnd = new Random();

                Console.WriteLine("Enter N:");
                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    queue.Enqueue(rnd.Next(0, 2));
                }

                PrintQueue(queue);

                queue = DeleteElementsEqualToFirstValue(queue);

                PrintQueue(queue);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        public static void PrintQueue(Queue<int> queue)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Current queue:");
            int i = 1;
            foreach (int e in queue)
            {
                Console.WriteLine($"{i}. {e.ToString()}");
                i++;
            }
            Console.WriteLine("--------------------------------");
        }

        public static Queue<int> DeleteElementsEqualToFirstValue(Queue<int> queue)
        {
            int first = queue.Peek();
            Console.WriteLine($"Deleting all values equal to the first element {first.ToString()} ");
            queue = new Queue<int>(queue.Where(x => x != first));
            return queue;

        }
    }
}
