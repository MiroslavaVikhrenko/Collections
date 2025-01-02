using System.Collections;

namespace _20250102_task3
{
    internal class Program
    {
        /*
         Создать ArrayList на 50 значений, заполнить. Используя бинарный поиск – найти определенное значение в списке
         */
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            int i = 0;
            while (i < 50)
            {
                Random rnd = new Random();
                arrayList.Add(rnd.Next(0,100));
                i++;
            }

            Console.WriteLine("Original array list:");
            Print(arrayList);

            arrayList.Sort();
            Console.WriteLine("Sorted array list:");
            Print(arrayList);

            try
            {
                Console.WriteLine("Enter the value you are looking for");
                int value = Convert.ToInt32(Console.ReadLine());
                int elementNumber = arrayList.BinarySearch(value);
                Console.WriteLine($"The value you search is element #{elementNumber}: {arrayList[elementNumber]}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            Console.ReadKey();
        }

        public static void Print(ArrayList arrayList)
        {
            Console.WriteLine("--------------------------------------------");
            for (int i = 0; i < arrayList.Count; i++)
            {
                if (i == arrayList.Count - 1)
                {
                    Console.Write($"{arrayList[i]}\n");
                }
                else
                {
                    Console.Write($"{arrayList[i]} | ");
                }
            }
            Console.WriteLine("--------------------------------------------");
        }
    }
}
