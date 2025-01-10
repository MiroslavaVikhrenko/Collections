namespace _20250110_task15
{
    internal class Program
    {
        /*
         Созданный Stack список разделить на два Stack списка: в первый поместить четные, 
        а во второй – нечетные числа. 
        Решить задачу в 2 варианта, в первом не извлекаем элементы изначальной коллекции, 
        во втором – извлекаем.
         */
        static void Main(string[] args)
        {
            Stack<int> originalStack = new Stack<int>();
            Console.WriteLine("Original stack in the begining");
            PopulateStack(originalStack);
            PrintStack(originalStack);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();

            Console.WriteLine("#1 Divide WITHOUT extraction");
            Stack<int> evenNumbersStack = new Stack<int>();
            Stack<int> unevenNumbersStack = new Stack<int>();
            DivideStack1(originalStack, evenNumbersStack, unevenNumbersStack);
            Console.WriteLine("Original stack AFTER DIVISION #1");
            PrintStack(originalStack);
            Console.WriteLine("Even numbers stack AFTER DIVISION #1");
            PrintStack(evenNumbersStack);
            Console.WriteLine("Uneven numbers stack AFTER DIVISION #1");
            PrintStack(unevenNumbersStack);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();


            Console.WriteLine("#2 Divide WITH extraction");
            Stack<int> evenNumbersStack2 = new Stack<int>();
            Stack<int> unevenNumbersStack2 = new Stack<int>();
            DivideStack2(originalStack, evenNumbersStack2, unevenNumbersStack2);
            Console.WriteLine("Original stack AFTER DIVISION #2");
            PrintStack(originalStack);
            Console.WriteLine("Even numbers stack AFTER DIVISION #2");
            PrintStack(evenNumbersStack2);
            Console.WriteLine("Uneven numbers stack AFTER DIVISION #2");
            PrintStack(unevenNumbersStack2);

            Console.ReadKey();
        }

        static void DivideStack1(Stack<int> originalStack, Stack<int> evenNumbersStack, Stack<int> unevenNumbersStack)
        {
            foreach (int i in originalStack)
            {
                if (i % 2 == 0)
                {
                    evenNumbersStack.Push(i);
                }
                else
                {
                    unevenNumbersStack.Push(i);
                }
            }
        }
        static void DivideStack2(Stack<int> originalStack, Stack<int> evenNumbersStack, Stack<int> unevenNumbersStack)
        {
            while (originalStack.Count > 0)
            {
                int i = originalStack.Pop();
                if (i % 2 == 0)
                {
                    evenNumbersStack.Push(i);
                }
                else unevenNumbersStack.Push(i);
            }
        }
        static void PopulateStack(Stack<int> originalStack)
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                originalStack.Push(rnd.Next(0, 10));
            }
        }

        static void PrintStack(Stack<int> originalStack)
        {
            Console.WriteLine("-----------------------");
            if (originalStack.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No elements in this stack. Stack is empty!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Printing stack...");
                foreach (int i in originalStack)
                {
                    if (i % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(i);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(i);
                        Console.ResetColor();
                    }
                }
            }            
            Console.WriteLine("-----------------------");
        }
    }
}
