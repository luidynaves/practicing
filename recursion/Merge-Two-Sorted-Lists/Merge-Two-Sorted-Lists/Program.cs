using System;

namespace Merge_Two_Sorted_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merge Two Sorted Lists");

            //var l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            //var l2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            var l1 = new ListNode(1, new ListNode(2));
            var l2 = new ListNode(1, new ListNode(3));

            var r = MergeTwoLists(l1, l2);

            while(r != null)
            {
                Console.Write($"{r.val} ");
                r = r.next;
            }

            Console.ReadKey();
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;

            if (l2 == null)
                return l1;

            if (l1.val <= l2.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }

            if (l1.val > l2.val)
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }

            return null;
        }
    }

    
  //Definition for singly-linked list.
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
 
}
