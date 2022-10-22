namespace LinkedList;

public class MiddleNode
{
    public ListNode Find(ListNode head)
    {
        if(head == null){
            return head;
        }
        ListNode ptr = head, p = head;
        var length = 0;
        
        while(ptr != null){
            length++;
            ptr = ptr.next;
        }
        ptr = head;
        var m = length/2;
        for(var i=0; i<m;i++){
            if(i<m-1){
                ptr = ptr.next;
            }
            p=p.next;
        }

        return p;
    }
}