namespace _20250110_task16
{
    internal class Program
    {
        /*
         Создать структуру цех: название, количество работников, количество станков. 
        Создать коллекцию Dictionary, добавить туда 2 коллекции цехов (в одной коллекции, минимум 3 объекта цеха). 
        При обращении к Dictionary по ключу, посчитать количество всех работников и вывести на экран.
         */
        static void Main(string[] args)
        {
            Dictionary<string, List<Department>> d = new Dictionary<string, List<Department>>();

            PopulateDictionary(d);

            CountNumberOfWorkers(d, "group 1");
            CountNumberOfWorkers(d, "group 2");

            Console.ReadKey();
        }

        public static void PopulateDictionary(Dictionary<string, List<Department>> d)
        {
            d.Add("group 1", new List<Department>()
            {
                new Department("department 1", 10, 15),
                new Department("department 2", 15, 23),
                new Department("department 3", 30, 50)
            });

            d.Add("group 2", new List<Department>()
            {
                new Department("department 4", 6, 10),
                new Department("department 5", 50, 80),
                new Department("department 6", 11, 14)
            });
        }
        public static void CountNumberOfWorkers(Dictionary<string, List<Department>> d, string key)
        {
            KeyValuePair<string, List<Department>> p = d.First(x => x.Key == key);
            int workers = 0;

            for (int i = 0; i < p.Value.Count; i++)
            {
                workers += p.Value[i].Workers;
            }
            Console.WriteLine($"For {key} key the total number if workers is {workers} ppl");
        }
    }

    

    public struct Department
    {
        public string Name;
        public int Workers;
        public int Machines;

        public Department(string name, int workers, int machines)
        {
            Name = name;
            Workers = workers;
            Machines = machines;
        }
    }
}
