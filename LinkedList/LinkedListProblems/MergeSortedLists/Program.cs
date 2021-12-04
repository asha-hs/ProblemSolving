using System;
using System.Collections.Generic;

namespace MergeSortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list1 = new LinkedList<int>();
            LinkedList<int> list2 = new LinkedList<int>();
            LinkedListNode<int> node;
            list1.AddLast(10);
            list1.AddLast(20);
            list1.AddLast(30);

            list2.AddLast(15);
            list2.AddLast(17);
            if (list1.First.Value < list2.First.Value)
                node = MergeInPlace(list1, list2);
            else
                node = MergeInPlace(list2, list1);
            PrintList(node);

        }

        public static void PrintList(LinkedListNode<int> head)
        {
            LinkedListNode<int> current = head;

            while(current != null)
            {
                Console.Write(current.Value + "  ");
                current = current.Next;
            }    
        }

        public static LinkedListNode<int> MergeInPlace(LinkedList<int> list1, LinkedList<int> list2)
        {
            
            LinkedListNode<int> head1 = list1.First, curr1 = head1, next1 = curr1.Next;
            LinkedListNode<int> head2 = list2.First, curr2 = head2, next2 = curr2.Next;

            while(next1 != null && curr2 !=null)
            {
                if(curr1.Value <= curr2.Value && next1.Value >= curr2.Value)
                {
                    next2 = curr2.Next;
                    curr1.Next = curr2;
                    curr2.Next = next1;
                }
            }
            return head1;

        }
    }
}
