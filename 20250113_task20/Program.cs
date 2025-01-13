using System.Collections.ObjectModel;

namespace _20250113_task20
{
    internal class Program
    {
        /*
         Создать обобщенный класс Item<T,V>, со свойствами Index<T>, Value<V>.  
        Создать класс Collection<T> с ограничением на использование класса Item. 
        Внутри класса Collection, создать коллекцию из элементов T. 
        Реализовать возможность добавления и вывода элементов коллекции.
         */
        static void Main(string[] args)
        {
            Item<int, string> i1 = new Item<int, string>(5, "table");
            Item<int, string> i2 = new Item<int, string>(7, "chair");
            Item<int, string> i3 = new Item<int, string>(3, "cabinet");
            Item<int, string> i4 = new Item<int, string>(6, "microwave");
            Item<int, string> i5 = new Item<int, string>(2, "stove");

            MyCollection<Item<int, string>> collection = new MyCollection<Item<int, string>>();

            collection.AddToMyCollection(i1);
            collection.AddToMyCollection(i2);
            collection.AddToMyCollection(i3);
            collection.AddToMyCollection(i4);
            collection.AddToMyCollection(i5);

            collection.PrintMyCollection();

            Item<DateTime, bool> i6 = new Item<DateTime, bool>(new DateTime(2024, 03, 25), true);
            Item<DateTime, bool> i7 = new Item<DateTime, bool>(new DateTime(2023, 11, 5), false);
            Item<DateTime, bool> i8 = new Item<DateTime, bool>(new DateTime(2022, 10, 13), false);
            Item<DateTime, bool> i9 = new Item<DateTime, bool>(new DateTime(2020, 02, 21), true);
            Item<DateTime, bool> i10 = new Item<DateTime, bool>(new DateTime(2025, 01, 10), true);

            MyCollection<Item<DateTime, bool>> collection2 = new MyCollection<Item<DateTime, bool>>();

            collection2.AddToMyCollection(i6);
            collection2.AddToMyCollection(i7);
            collection2.AddToMyCollection(i8);
            collection2.AddToMyCollection(i9);
            collection2.AddToMyCollection(i10);

            collection2.PrintMyCollection();

            Console.ReadKey();
        }
    }

    public class MyCollection<Item> : Collection<Item>
    {
        Collection<Item> Items { get; set; }
        public MyCollection()
        {
            Items = new Collection<Item>();
        }

        public void AddToMyCollection(Item item)
        {
            Items.Add(item);
            Console.WriteLine($"Item ({item.ToString()}) added to collection");
        }

        public void PrintMyCollection()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("All collection:");
            for (int i = 0; i < Items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Items[i].ToString()}");
            }
            Console.WriteLine("------------------------");
        }
    }
    public class Item<T, V>
    {
        public T Index { get; set; }
        public V Value { get; set; }
        public Item(T index, V value)
        {
            Index = index;
            Value = value;
        }
        public override string ToString()
        {
            return $"Index: {Index.ToString()}, value: {Value.ToString()}";
        }
    }
}
