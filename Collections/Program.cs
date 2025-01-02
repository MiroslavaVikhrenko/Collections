namespace Collections
{
    internal class Program
    {
        /*
         Создать класс – Мебель, со свойствами: id, производитель, модель, цена, габариты(кортеж Ш:В:Д). 
         Создать список класса List на 5 элементов. Используя метод в классе, вывести информацию на экран.
         */
        static void Main(string[] args)
        {
            List<Furniture> list = new List<Furniture>() 
            {
                new Furniture("Maker1", "Model1", 20.0m),
                new Furniture("Maker2", "Model2", 30.0m),
                new Furniture("Maker3", "Model3", 40.0m),
                new Furniture("Maker4", "Model4", 50.0m),
                new Furniture("Maker5", "Model5", 60.0m)
            };

            foreach (Furniture f in list)
            {
                Console.WriteLine(f.ToString());
            }


            Console.ReadKey();
        }
    }

    public class Furniture
    {
        public Guid Id { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public Tuple<int, int, int> Size { get; set; }

        public Furniture(string maker, string model, decimal price)
        {
            Id = Guid.NewGuid();
            Maker = maker;
            Model = model;
            Price = price;
            Size = Tuple.Create(1, 1, 1);

        }

        public override string ToString()
        {
            return $"{Id} {Maker} {Model}, price: {Price} CAD";
        }
    }
}
