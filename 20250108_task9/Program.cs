using System.Xml.Linq;

namespace _20250108_task9
{
    internal class Program
    {
        /*
         Создать класс «Университет ». Используя LinkedList, вывести студентов с баллом 4 и выше. 
        После, реализовать метод добавление новых студентов, студент у которого оценка ниже 4, 
        добавляется в конец списка, у которого выше – в начало.
         */
        static void Main(string[] args)
        {
            University u = new University();

            u.Students.AddFirst(new Person("Sophia", 3));
            u.Students.AddFirst(new Person("Kate", 4));
            u.Students.AddFirst(new Person("Tom", 5));
            u.Students.AddFirst(new Person("Lucas", 3));
            u.Students.AddFirst(new Person("Makoto", 4));
            u.Students.AddFirst(new Person("Ravi", 5));
            u.Students.AddFirst(new Person("Ken", 2));
            u.Students.AddFirst(new Person("Tyler", 4));
            u.Students.AddFirst(new Person("Ling", 3));

            
            u.PrintAll();
            u.PrintBestStudents();

            Console.ReadKey();

            while (true)
            {
                u.AddStudent();
            }
            
        }
    }

    public class University
    {
        public LinkedList<Person> Students { get; set; }
        public University()
        {
            Students = new LinkedList<Person>();
        }

        public void PrintAll()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("All students:");
            for (LinkedListNode<Person> student = Students.First; student != null; student = student.Next)
            {
                Console.WriteLine(student.Value);
            }
            Console.WriteLine("-----------------------------");
        }

        public void PrintBestStudents()
        {
            Console.WriteLine("Best students:");
            for (LinkedListNode<Person> student = Students.First; student != null; student = student.Next)
            {
                if (student.Value.Grade >= 4)
                Console.WriteLine(student.Value);
            }
            Console.WriteLine("-----------------------------");
        }

        public void AddStudent()
        {
            Console.Clear();
            Console.WriteLine("Let's add new students...");
            Console.WriteLine("Please enter student's name:");
            try
            {
                string name = Console.ReadLine();
                Console.WriteLine($"Please enter {name} grade:");
                int grade = Convert.ToInt32( Console.ReadLine() );

                Person p = new Person(name, grade);

                Console.WriteLine($"Adding {name} to the list... ");

                if (grade < 4)
                {
                    Students.AddLast(p);
                }
                else
                {
                    Students.AddFirst(p);
                }
                PrintAll();
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public Person(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }
        public override string ToString()
        {
            return $"{Name}: {Grade}";
        }
    }
}
