using System;

namespace HashingAlg
{
    internal class Program
    {
        //my hash values/ linked list storage
        public static Random rng = new Random();
        static Node[] HashTable = new Node[10];
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    Console.WriteLine($"Please add a value of data");
            //    AddItem(Console.ReadLine());
            //}
            int NumberOf = rng.Next(1, 150);
            for (int i = 0; i < NumberOf; i++)
            {
                AddItem($"Patrick-{rng.Next(0, 999)}");
            }

            dispCont();

            Console.ReadLine();
        }

        static void AddItem(string DataToAdd)
        {
            Node NewNodeToAdd = new Node();

            NewNodeToAdd.data = DataToAdd;

            int hashValue = CalculateHashValue(DataToAdd);

            if (HashTable[hashValue] != null)
            {
               //To Add to the linked list as another node exists
               Node CurrentNode = HashTable[hashValue];
                while (CurrentNode != null)
                {
                    CurrentNode = CurrentNode.ptrNextNode;
                }

               
            }
            else
            {   
                HashTable[hashValue] = NewNodeToAdd;
            }
        }

        static int CalculateHashValue(string key)
        {
            int hashValue = (int)key[0] % 10;
            return hashValue;
        }

        static void dispCont()
        {
            int Index = 0;
            foreach (Node n in HashTable)
            {
                if (n != null)
                {
                    Console.WriteLine(n.data);
                    Node currentNode = n;
                    while (currentNode.ptrNextNode != null)
                    {
                        Console.WriteLine($"{Index}: {n.data}");
                        currentNode = currentNode.ptrNextNode;
                        Index++;
                    }
                }
                
            }
        }
    }
}
