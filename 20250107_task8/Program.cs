namespace _20250107_task8
{
    internal class Program
    {
        /*
         Создать класс «Аэропорт». Реализовать добавление очереди пассажиров на самолет. 
        Реализовать посадку на самолет, используя Queue. 
        В консоли выводить кто зарегистрировался, кто сел на самолет.
         */
        static void Main(string[] args)
        {
            Airport airport = new Airport();
            for (int i = 0; i < airport.BusinessPassengers.Count; i++)
            {
                Console.WriteLine(airport.BusinessPassengers[i].ToString());
                Console.WriteLine(airport.EconomyPassengers[i].ToString());
            }

            for (int i = 0; i < 5; i++)
            {
                airport.RegisterBusinessQueue();
                airport.RegisterEconomyQueue();
            }
            for (int i = 0; i < 5; i++)
            {
                airport.RegisterBusinessClass();
                airport.RegisterEconomyClass();
            }

            airport.BoardBusinessClass();
            airport.BoardEconomyClass();
            Console.ReadKey();
        }
    }

    public class Airport
    {
        public List<Passenger> EconomyPassengers { get; set; }
        public List<Passenger> BusinessPassengers { get; set; }
        public Queue<Passenger> EconomyRegisterQueue { get; set; }
        public Queue<Passenger> BusinessRegisterQueue { get; set; }
        public Queue<Passenger> EconomyBoardingQueue { get; set; } 
        public Queue<Passenger> BusinessBoardingQueue { get; set; } 

        public Airport()
        {
            EconomyPassengers = new List<Passenger>();
            for (int i = 0; i < 5;  i++)
            {
                Passenger p = new Passenger();
                p.Class = Class.Economy;
                EconomyPassengers.Add(p);

            }
            BusinessPassengers = new List<Passenger>();
            for (int i = 0; i < 5; i++)
            {
                Passenger p = new Passenger();
                p.Class = Class.Business;
                BusinessPassengers.Add(p);

            }

            EconomyRegisterQueue = new Queue<Passenger>();
            BusinessRegisterQueue = new Queue<Passenger>();
            EconomyBoardingQueue = new Queue<Passenger>();
            BusinessBoardingQueue = new Queue<Passenger>();
        }

        public void RegisterBusinessQueue()
        {
            Random rnd = new Random();
            Passenger passenger = BusinessPassengers[rnd.Next(0, BusinessPassengers.Count)];
            BusinessRegisterQueue.Enqueue(passenger);            
            BusinessPassengers.Remove(passenger);
            Console.WriteLine($"Passenger {passenger} joined registration queue. Queue size is {BusinessRegisterQueue.Count} people\n");
        }
        public void RegisterEconomyQueue()
        {
            Random rnd = new Random();
            Passenger passenger = EconomyPassengers[rnd.Next(0, EconomyPassengers.Count)];
            EconomyRegisterQueue.Enqueue(passenger);
            EconomyPassengers.Remove(passenger);
            Console.WriteLine($"Passenger {passenger} joined registration queue. Queue size is {EconomyRegisterQueue.Count} people\n");
        }

        public void RegisterBusinessClass()
        {
            Passenger passenger = BusinessRegisterQueue.Dequeue();
            Console.WriteLine($"Passenger {passenger} successfully completed registration and heading to the boarding queue. Queue size is {BusinessRegisterQueue.Count} people\n");
            BoardingBusinessQueue(passenger);
        }
        public void RegisterEconomyClass()
        {
            Passenger passenger = EconomyRegisterQueue.Dequeue();
            Console.WriteLine($"Passenger {passenger} successfully completed registration and heading to the boarding queue. Queue size is {EconomyRegisterQueue.Count} people\n");
            BoardingEconomyQueue(passenger);
        }

        public void BoardingBusinessQueue(Passenger passenger)
        {
            BusinessBoardingQueue.Enqueue(passenger);
            Console.WriteLine($"{passenger} joined boarding queue. Queue size is {BusinessBoardingQueue.Count} people\n");
        }
        public void BoardingEconomyQueue(Passenger passenger)
        {
            EconomyBoardingQueue.Enqueue(passenger);
            Console.WriteLine($"{passenger} joined boarding queue. Queue size is {EconomyBoardingQueue.Count} people\n");
        }

        public void BoardBusinessClass()
        {
            while (BusinessBoardingQueue.Count > 0)
            {
                Passenger passenger = BusinessBoardingQueue.Dequeue();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{passenger} successfully got on board");
                Console.ResetColor();
                Console.WriteLine($"Queue size is {BusinessBoardingQueue.Count} people\n");
            }
            if ( BusinessBoardingQueue.Count == 0 ) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"ALL BUSINESS CLASS PASSENGERS ARE ON BOARD\n\n\n\n\n");
                Console.ResetColor();
                Console.WriteLine("----------------------------------------------------------------");
            }
        }

        public void BoardEconomyClass()
        {
            while (EconomyBoardingQueue.Count > 0)
            {
                Passenger passenger = EconomyBoardingQueue.Dequeue();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{passenger} successfully got on board");
                Console.ResetColor();
                Console.WriteLine($"Queue size is {EconomyBoardingQueue.Count} people\n");
            }
            if (EconomyBoardingQueue.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"ALL ECONOMY CLASS PASSENGERS ARE ON BOARD\n\n\n\n\n");
                Console.ResetColor();
                Console.WriteLine("----------------------------------------------------------------");
            }
        }
    }
    public enum Class
    {
        Economy,
        Business
    }
    public class Passenger
    {
        private readonly string[] firstnames = { "Adam", "Amily", "Bill", "Bob", "Brian", "Noah", "Olivia", "Sophia", "Oliver", "Lucas", "Mark", "Alex", "Liam", "Thomas", "Jack", "Lily", "Chloe", "Leo", "Amelia", "Emma", "Mia", "Ava", "William", "Charlie", "Gabriella", "Kate", "Jessica", "Lilith", "Erik", "Ravi", "Makoti", "Ken", "Peter", "Tyler" };
        private readonly string[] lastnames = { "Adams", "Allen", "Baker", "Bell", "Brown", "Campbell", "Chen", "Collins", "Davis", "Edwards", "Gray", "Hamilton", "Harris", "Jackson", "Johnson", "Jones", "Kelly", "Liu", "Marshall", "Miller", "Moore", "Nguyen", "Park", "Reid", "Shaw", "Simpson", "Van", "Wang", "Williams", "Wilson", "Yang" };
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Class Class { get; set; }
        public Passenger()
        {
            Random rnd = new Random();
            FirstName = firstnames[rnd.Next(0, firstnames.Length)];
            LastName = lastnames[rnd.Next(0, lastnames.Length)];
        }

        public override string ToString()
        {
            if (Class == Class.Business)
            {
                return $"{FirstName} {LastName} (B)";
            }
            else
            {
                return $"{FirstName} {LastName} (E)";
            }
        }
    }
}
