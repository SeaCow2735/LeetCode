/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        ListNode ans = new ListNode(0, head);
        ListNode dummy = ans;

        while (dummy.next != null)
        {
            if (dummy.next.val == val)
            {
                dummy.next = dummy.next.next;
            }
            else
            {
                dummy = dummy.next;
            }
        }
        return ans.next;
    }
}
