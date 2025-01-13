using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace _20250113_task17
{
    internal class Program
    {
        //Создать коллекцию по типу ObservableCollection<int>, попробовать удалить, добавить и заменить объект. 
        static void Main(string[] args)
        {
            ObservableCollection<int> ints = new ObservableCollection<int>();
            ints.CollectionChanged += Ints_CollectionChanged;
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(4);
            ints.Add(5);;
            ints[0] = ints[1];
            ints.RemoveAt(0);
            ints.Remove(5);
            Console.ReadKey();
        }

        private static void Ints_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: 
                    Console.WriteLine($"Added new element: {e.NewItems[0]}");
                    break;
                case NotifyCollectionChangedAction.Remove: 
                    Console.WriteLine($"Deleted old element: {e.OldItems[0]}");
                    break;
                case NotifyCollectionChangedAction.Replace: // если замена
                    Console.WriteLine($"Elemeny {e.NewItems[0]} added, replacing old element - {e.OldItems[0]}.");
                    break;
            }
        }
    }
}