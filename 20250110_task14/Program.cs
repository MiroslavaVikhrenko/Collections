namespace _20250110_task14
{
    internal class Program
    {
        /*
         Описать класс «Англо-Французский словарь» , обеспечивающий возможность хранения нескольких вариантов 
        перевода для каждого слова. Реализовать доступ по строковому индексу - английскому слову. 
        Использовать класс Dictionary.
         */
        static void Main(string[] args)
        {
            EnglishJapaneseDictionary d = new EnglishJapaneseDictionary();
            d.PopulateColors();
            d.PopulateVerbs();
            d.PopulatePronouns();

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------------------Welcome to English-Japanese dictionary------------------");
                Console.ResetColor();
                try
                {
                    Console.WriteLine("Choose category:\n1.Colors\n2.Verbs\n3.Pronouns");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the word you want to translate:");
                    string word = Console.ReadLine();
                    switch (choice)
                    {
                        case 1: d.TranslateColor(word); break;
                        case 2: d.TranslateVerbs(word); break;
                        case 3: d.TranslatePronouns(word); break;
                        default: Console.WriteLine("Sorry, this option is not available. Try again"); break;
                    }
                    Console.ReadKey();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }

    public class EnglishJapaneseDictionary
    {
        public Dictionary<string, string[]> Colors { get; set; }
        public Dictionary<string, string[]> Verbs { get; set; }
        public Dictionary<string, string[]> Pronouns { get; set; }

        public EnglishJapaneseDictionary()
        {
            Colors = new Dictionary<string, string[]>();
            Verbs = new Dictionary<string, string[]>();
            Pronouns = new Dictionary<string, string[]>();
        }

        public void PopulateColors()
        {
            Colors.Add("green", new string[] { "midori", "aoi" });
            Colors.Add("red", new string[] { "akai", "beni", "shu", "reddo"});
            Colors.Add("blue", new string[] { "kon", "aoi", "mizuiro", "uminoiro" });
            Colors.Add("gray", new string[] { "haiiro", "nezumiiro", "gurei" });
            Colors.Add("violet", new string[] { "murasaki", "fujiiro", "sumireiro" });
        }
        public void PopulateVerbs()
        {
            Verbs.Add("go", new string[] { "iku", "aruku" });
            Verbs.Add("eat", new string[] { "taberu", "kuu", "meshiageru", "shokujisuru" });
            Verbs.Add("jump", new string[] { "tobu", "jyampusuru" });
            Verbs.Add("talk", new string[] { "shaberu", "iu", "hanasu", "kaidansuru"});
            Verbs.Add("do", new string[] { "suru", "tsukuru" });
        }
        public void PopulatePronouns()
        {
            Pronouns.Add("I", new string[] {"watashi", "kotira", "ware", "washi", "boku", "ore", "kocchi", "atashi", "watakushi", "uchi"});
            Pronouns.Add("You", new string[] { "anata", "sotira", "omae" });
            Pronouns.Add("He", new string[] { "kare", "anohito", "atira", "anokata"});
            Pronouns.Add("She", new string[] { "kanojo", "anohito", "atira", "anokata" });
            Pronouns.Add("We", new string[] { "watashitati", "wareware" });
            Pronouns.Add("They", new string[] { "anohitotati", "atira", "karera"});
        }

        public void TranslateColor(string color)
        {
            Console.WriteLine("-------------------------------");
            if (Colors.ContainsKey(color))
            {
                Console.WriteLine($"{color} = ");
                string[] values = Colors[color];
                for (int i = 0; i < values.Length; i++)
                {
                    Console.WriteLine($">> {i+1}.{values[i]}");
                }
                Console.WriteLine("-------------------------------");
            }
            else
            {
                Console.WriteLine($"Sorry, '{color}' was not added to the dictionary yet.");
            }  
        }
        public void TranslateVerbs(string verb)
        {
            Console.WriteLine("-------------------------------");
            if (Verbs.ContainsKey(verb))
            {
                Console.WriteLine($"{verb} = ");
                string[] values = Verbs[verb];
                for (int i = 0; i < values.Length; i++)
                {
                    Console.WriteLine($">> {i + 1}.{values[i]}");
                }
                Console.WriteLine("-------------------------------");
            }
            else
            {
                Console.WriteLine($"Sorry, '{verb}' was not added to the dictionary yet.");
            }
        }
        public void TranslatePronouns(string pronoun)
        {
            Console.WriteLine("-------------------------------");
            if (Pronouns.ContainsKey(pronoun))
            {
                Console.WriteLine($"{pronoun} = ");
                string[] values = Pronouns[pronoun];
                for (int i = 0; i < values.Length; i++)
                {
                    Console.WriteLine($">> {i + 1}.{values[i]}");
                }
                Console.WriteLine("-------------------------------");
            }
            else
            {
                Console.WriteLine($"Sorry, '{pronoun}' was not added to the dictionary yet.");
            }
        }
    }
}
