using System;

namespace NeetCode150.LinkedList
{
    // Definition for singly-linked list node
    public class ListNode 
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null) 
        {
            this.val = val;
            this.next = next;
        }
    }

    // Problem: Reverse Linked List
    // Given the head of a singly linked list, reverse the list, and return the reversed list.
    
    public class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            
            while (curr != null)
            {
                ListNode nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp;
            }
            
            return prev;
        }
        
        public static void Main(string[] args)
        {
            ReverseLinkedList solution = new ReverseLinkedList();
            
            // Example 1: [1,2,3,4,5] -> [5,4,3,2,1]
            ListNode head1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            ListNode result1 = solution.ReverseList(head1);
            PrintList(result1); // Expected: 5 -> 4 -> 3 -> 2 -> 1
            
            // Example 2: [1,2] -> [2,1]
            ListNode head2 = new ListNode(1, new ListNode(2));
            ListNode result2 = solution.ReverseList(head2);
            PrintList(result2); // Expected: 2 -> 1
            
            // Example 3: [] -> []
            ListNode head3 = null;
            ListNode result3 = solution.ReverseList(head3);
            PrintList(result3); // Expected: (empty)
        }
        
        private static void PrintList(ListNode head)
        {
            ListNode current = head;
            while (current != null)
            {
                Console.Write(current.val);
                if (current.next != null)
                    Console.Write(" -> ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}