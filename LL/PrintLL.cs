using System;

namespace LL
{
    public class PrintLL
    {
        public void Print(LinkedList head)
        {
            var current = head;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }

        public void PrintRecursive(LinkedList head)
        {
            if(head == null) return;
            Console.WriteLine(head.Value);
            PrintRecursive(head.Next);
        }
    }
}