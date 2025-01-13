using System.Collections.ObjectModel;

namespace _20250113_task19
{
    internal class Program
    {
        /*
         Создать собственную универсальную коллекцию на основе абстрактного класса Collection<T>.
         */
        static void Main(string[] args)
        {
            MyCollection<int> ints = new MyCollection<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.PrintCollection();
            ints.ReplaceElements(1, 2);

            MyCollection<int> ints2 = new MyCollection<int>();
            ints2.Add(5);
            ints2.Add(6);
            ints2.Add(7);
            
            MyCollection<int> newInts = ints.InsertCollectionInTheBegining(ints2);

            newInts.Add(5);
            newInts.Add(6);
            newInts.Add(3);
            newInts.Add(4);
            newInts.Add(5);
            newInts.Add(1);
            newInts.Add(2);
            Console.WriteLine("Enahnced collection with repetitive elements:");
            newInts.PrintCollection();

            MyCollection<int> uniqueCollection = newInts.GetOnlyUniqueValues();

            Console.ReadKey();
        }
    }

    public class MyCollection<T> : Collection<T>
    {
        public void PrintCollection()
        {
            Console.WriteLine("------------------");
            foreach (var item in Items)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("------------------");
        }

        public void ReplaceElements(int a, int b)
        {
            T temp = Items[a];
            Items[a] = Items[b];
            Items[b] = temp;
            Console.WriteLine($"Elements on positions #{a+1} and #{b+1} were switched");
            Console.WriteLine("------------------");
            Console.WriteLine("Updated collection:");
            PrintCollection();
        }

        public MyCollection<T> InsertCollectionInTheBegining(MyCollection<T> adddedCollection)
        {
            MyCollection<T> newCollection = new MyCollection<T>();

            foreach (var item in adddedCollection)
            {
                newCollection.Add(item);
            }

            foreach (var item in Items)
            {
                newCollection.Add(item);
            }

            Console.WriteLine("Joint collection:");
            newCollection.PrintCollection();
            return newCollection;
        }

        public MyCollection<T> GetOnlyUniqueValues()
        {
            MyCollection<T> uniqueCollection = new MyCollection<T>();


            for (int i = 0; i < Items.Count; i++)
            {
                if (!uniqueCollection.Contains(Items[i]))
                {
                    uniqueCollection.Add(Items[i]);
                }
            }

            Console.WriteLine("------------------");
            Console.WriteLine("Unique elements are:");
            uniqueCollection.PrintCollection();
            return uniqueCollection;
        }
    }
}
