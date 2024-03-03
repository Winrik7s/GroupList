namespace Winki.SingleLinkedList.Test
{
    public class Progam
    {
        static void Main(string[] args)
        {
            SingleList listSL = new();

            listSL.AddSL("7");
            listSL.AddSL("13");
            listSL.AddSL("28");

            listSL.LoopSL();
        }
    }
}
