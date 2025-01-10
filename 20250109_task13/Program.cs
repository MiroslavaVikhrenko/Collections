namespace _20250109_task13
{
    internal class Program
    {
        /*
         Напишите программу, которая принимает на вход строку, и выводит слово, которое встречается во фразе реже всего. 
        Если редких слов несколько, нужно вывести то, которое меньше в лексикографическом порядке. 
        Регистр слов не учитывается, знаки препинания в предложениях игнорируются.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter string:");
            string str = Console.ReadLine();

            string[] strArray = str.Split(" ");

            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            Dictionary<string, int> dictionary = new Dictionary<string, int>(comparer);

            foreach (string item in strArray)
            {
                if (dictionary.ContainsKey(item))
                {
                    dictionary[item] += 1;
                }
                else
                {
                    dictionary.Add(item, 1);
                }
            }


            dictionary = dictionary.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            string temp = dictionary.ElementAt(0).Key;

            foreach(var item in dictionary)
            {
                if (item.Value == dictionary.ElementAt(0).Value)
                {
                    if (item.Key.Length < temp.Length)
                    {
                        temp = item.Key;
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(temp);

            Console.ReadKey();
        }
    }
}
