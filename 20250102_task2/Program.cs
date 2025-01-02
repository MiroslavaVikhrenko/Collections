using System.Collections;

namespace _20250102_task2
{
    internal class Program
    {
        /*
         Создать ArrayList на 100 значений, заполнить и отсортировать в убывающем порядке.
         */
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            int i = 0;

            while (i < 100)
            {
                Random rnd = new Random();
                arrayList.Add(rnd.Next(0,100));
                i++;
            }

            Print(arrayList);

            arrayList.Sort();
            //arrayList.Reverse();

            Print(arrayList);

            Console.ReadKey();
        }

        public static void Print(ArrayList arrayList)
        {
            foreach (int i in arrayList)
            {
                Console.Write($"{i} |");
            }
            Console.WriteLine();
        }
    }
}
