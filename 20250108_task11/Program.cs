using System.Collections.Generic;

namespace _20250108_task11
{
    internal class Program
    {
        /*
         Удалить все положительные числа из двусвязного списка.
         */
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = PopulateList();
            PrintLinkedList(linkedList);

            RemoveAllPositiveNumbersFromLinkedList(linkedList);
            PrintLinkedList(linkedList);

            Console.ReadKey();
        }

        static LinkedList<int> PopulateList()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                linkedList.AddLast(rnd.Next(-9, 10));
            }
            return linkedList;
        }
        static void PrintLinkedList(LinkedList<int> linkedList)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Current linked list:");

            foreach (int i in linkedList)
            {
                Console.WriteLine(i);
            }
        }

        static void RemoveAllPositiveNumbersFromLinkedList(LinkedList<int> linkedList)
        {
            var node = linkedList.First;
            while (node != null)
            {
                var nextNode = node.Next;
                if (node.Value >= 0)
                {
                    linkedList.Remove(node);
                }
                node = nextNode;
            }
        }
    }
}
