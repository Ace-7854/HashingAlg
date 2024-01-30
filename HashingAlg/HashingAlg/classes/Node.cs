namespace HashingAlg
{
    internal class Node
    {
        public string data { get; set; }

        public Node ptrNextNode { get; set; }

        public Node()
        {
            ptrNextNode = null;
        }
    }
}
