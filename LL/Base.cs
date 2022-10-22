namespace LL
{
    public class LinkedList
    {
        public LinkedList Next;
        public readonly object Value;

        public LinkedList(object value)
        {
            Value = value;
            Next = null;
        }
    }
}