using System;
using System.Collections.Generic;

namespace MergeSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList<int> list1 = new LinkedList<int>();
            LinkedList<int> list2 = new LinkedList<int>();
            LinkedListNode node = MergeInPlace(list1, list2);
        }

        public static LinkedListNode MergeInPlace(LinkedList<int> list1, LinkedList<int> list2)
        {
            LinkedListNode head1 = list1.First;

            return head1;

        }
    }
}
