namespace LL
{
    public static class AddToNodes
    {
        public static LinkedList Add(LinkedList l1, LinkedList l2)
        {
            var result = new LinkedList(0);
            LinkedList list1 = l1, list2 = l2, current = result;
            int carry = 0;
        
            while(list1 != null || list2 != null){
                object var1 = list1 !=null ? list1.Value : 0;
                object var2 = list2 !=null ? list2.Value : 0;
                int sum = (int)var1 + (int)var2 + carry;
                carry = sum/10;
                current.Next = new LinkedList(sum%10);
                current = current.Next;
                list1 = list1?.Next;
                list2 = list2?.Next;
            }
            if(carry>0){
                current.Next = new LinkedList(carry);
            }
        
            return result.Next; 
        }
    }
}