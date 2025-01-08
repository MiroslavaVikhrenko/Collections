namespace _20250108_task12
{
    internal class Program
    {
        /*
         Есть классы  «Фирма » и «Сотрудники », у каждого сотрудника есть своя должность. 
        Реализовать добавление сотрудников в хаотичном порядке, используя коллекцию Queue. 
        Вывод сотрудников организовать в порядке убывания по важности должности. 
        К примеру, сначала выводятся директора, потом менеджеры и так далее.
         */
        static void Main(string[] args)
        {
            Firm f = new Firm();
            f.PrintEmployees();
            f.SortEmployyes();
            f.PrintEmployees();

            Console.ReadKey();
        }
    }

    public class Firm
    {
        public Queue<Employee> Employees { get; set; }

        public Firm()
        {
            Employees = new Queue<Employee>();

            for (int i = 0; i < 10; i++)
            {
                Employees.Enqueue(new Employee());
            }
        }

        public void PrintEmployees()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("List of employees:");
            foreach (Employee emp in Employees)
            {
                Console.WriteLine(emp.ToString());
            }
            Console.WriteLine("------------------------");
        }

        public void SortEmployyes()
        {
            Queue<Employee> sortedEmployeeList = new Queue<Employee>();

            Console.WriteLine("Sorting employees by their position...");
            foreach (Employee e in Employees)
            {
                if (e.Position == Position.Director)
                {
                    sortedEmployeeList.Enqueue(e);
                }
            }
            foreach (Employee e in Employees)
            {
                if (e.Position == Position.Manager)
                {
                    sortedEmployeeList.Enqueue(e);
                }
            }

            foreach (Employee e in Employees)
            {
                if (e.Position == Position.Consultant)
                {
                    sortedEmployeeList.Enqueue(e);
                }
            }
            foreach (Employee e in Employees)
            {
                if (e.Position == Position.Worker)
                {
                    sortedEmployeeList.Enqueue(e);
                }
            }

            Employees = sortedEmployeeList;
        }
    }

    public enum Position
    {
        Worker,
        Consultant,
        Manager,
        Director
    }

    public class Employee
    {
        private readonly string[] names = { "Kate", "Liza", "Adam", "Taro", "Lucy", "Erik", "Chris", "Sophia", "Mark" };
        public string Name { get; set; }
        public Position Position { get; set; }
        public Employee()
        {
            Random rnd = new Random();
            Name = names[rnd.Next(0,names.Length)];
            int p = rnd.Next(0,4);
            switch (p)
            {
                case 0: Position = Position.Worker; break;
                case 1: Position = Position.Consultant; break;
                case 2: Position = Position.Manager; break;
                case 3: Position = Position.Director; break;
            }
        }

        public override string ToString()
        {
            return $"{Position} : {Name}";
        }
    }
}
