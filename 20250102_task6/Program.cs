namespace _20250102_task6
{
    internal class Program
    {
        /*
         В пассажирском поезде 15 вагонов. 
        Известно, что все вагоны с четными номерами купейные (36 мест), 
        а с нечетными номерами плацкартные (52 места). 
        Обеспечить ввод количества занятых мест в каждом вагоне. 
        Учесть, что вагон No10 – это ресторан. 
        Выдать на печать номера вагонов, в которых есть свободные места, использовать List.
         */
        static void Main(string[] args)
        {
            List<Wagon> wagons = new List<Wagon>(15);

            int count = 1;

            while (count <= 15)
            {
                if (count == 10)
                {
                    wagons.Add(new Restaurant());
                }
                else if (count % 2 == 0)
                {
                    wagons.Add(new Kupe());
                }
                else
                {
                    wagons.Add(new Platskart());
                }
                count++;
            }

            PrintInfo(wagons);

            Console.ReadKey();
        }

        public static void PrintInfo(List<Wagon> wagons)
        {
            Console.WriteLine("Train info:");

            for (int i = 0; i < wagons.Count; i++)
            {
                if (wagons[i] is Restaurant)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (wagons[i] is Kupe)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine($"Wagon #{i+1}: {wagons[i].ToString()}");
                Console.ResetColor();
            }
        }
    }
}
