using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace _20250113_task18
{
    internal class Program
    {
        /*
         Создать класс Car, с полями: марка, модель, год, цена. 
        Создать коллекцию типа Car, попробовать удалять, добавить и заменить объект.
         */
        static void Main(string[] args)
        {
            Car c1 = new Car("Toyota", "Corolla", new DateTime(2015, 01, 01), 22000.0m);
            Car c2 = new Car("Toyota", "Highlander", new DateTime(2018, 01, 01), 25000.0m);
            Car c3 = new Car("Toyota", "Camry", new DateTime(2020, 01, 01), 28000.0m);
            Car c4 = new Car("Honda", "Accord", new DateTime(2023, 01, 01), 29000.0m);
            Car c5 = new Car("Honda", "Civic", new DateTime(2019, 01, 01), 24000.0m);
            Car c6 = new Car("Mitsubishi", "Mirage", new DateTime(2021, 01, 01), 25500.0m);
            Car c7 = new Car("Mitsubishi", "Outlander", new DateTime(2016, 01, 01), 20000.0m);

            ObservableCollection<Car> cars = new ObservableCollection<Car>();
            cars.CollectionChanged += Cars_CollectionChanged;
            cars.Add(c1);
            cars.Add(c2);
            cars.Add(c3);
            cars[2] = c4;
            cars.Remove(c1);
            cars.Remove(c2);
            cars.Add(c5);
            cars.Add(c6);
            cars[0] = c7;

            Console.ReadKey();
        }

        private static void Cars_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: 
                    Car newCar = e.NewItems[0] as Car;
                    Console.WriteLine($"Added new car: {newCar}");
                    break;
                case NotifyCollectionChangedAction.Remove: 
                    Car oldCar = e.OldItems[0] as Car;
                    Console.WriteLine($"Deleted old car: {oldCar}");
                    break;
                case NotifyCollectionChangedAction.Replace: 
                    Car replacedCar = e.OldItems[0] as Car;
                    Car replacingCar = e.NewItems[0] as Car;
                    Console.WriteLine($"Old car - {replacedCar} -  was replaced by {replacingCar}");
                    break;
            }
        }
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public decimal Price { get; set; }
        public Car(string brand, string model, DateTime year, decimal price)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Brand} {Model} {Year.Year} Price: {Price} CAD";
        }
    }
}
