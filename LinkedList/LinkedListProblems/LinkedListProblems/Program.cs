using System;
using System.Collections.Generic;

namespace LinkedListProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(1);
            ll.AddLast(2);
            ll.AddLast(3);
            ll.AddLast(4);
            ll.AddLast(5);

            int kthNodeVal = FindNthNodeFromEnd(ll, 3);

            Console.WriteLine("3nd node from end = " + kthNodeVal);
        }

        public static  int FindNthNodeFromEnd(LinkedList<int> list,int k)
        {
            int n = list.Count;
            int x = n - k;
            LinkedListNode<int> current = list.First;
            for(int i = 0; i < x; i++)
            {
                current = current.Next;
            }

            return current.Value;
        }
    }

    public class Node
    {
        public int data;
        public Node next;

        public Node(int a)
        {
            this.data = a;
            this.next = null;
        }
    }
}
