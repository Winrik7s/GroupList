namespace Winki.SingleLinkedList.Test
{
    public class SingleList
    {
        public Node? Head { get; set; }

        public void AddSL(object data)
        {

            if (Head == null)
            {
                Head = new Node() { Data = data };
            }
            else
            {
                Node Current = Head;

                while (Current.Next != null)
                {
                    Current = Current.Next;
                }

                Current.Next = new Node() { Data = data };
            }
        }

        public void LoopSL()
        {
            Node Current = Head;

            while (Current != null)
            {
                Console.WriteLine(Current.Data);
                Current = Current.Next;
            }
        }
    }
}
