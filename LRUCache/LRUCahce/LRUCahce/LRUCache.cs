using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRUCahce
{
    class LRUCache
    {
        Node head = new Node(0, 0);
        Node tail = new Node(0, 0);
        int capacity;
        Dictionary<int, Node> map = new Dictionary<int, Node>();

        public LRUCache(int cap)
        {
            capacity = cap;
            head.next = tail;
            tail.prev = head;
        }

        public int Get(int key)
        {
            if (map.ContainsKey(key))
            {
                Node node = map[key];
                remove(node);
                insert(node);
                return node.value;
            }else
            {
                return -1;
            }
        }
        public void Set(int key, int value)
        {
            if(map.ContainsKey(key))
            {
                remove(map[key]);
            }
            if(map.Count == capacity)
            {
                remove(tail.prev);
            }
            insert(new Node(key, value));
        }
        private void remove(Node node)
        {
            map.Remove(node.key);
            node.prev.next = node.next;
            node.next.prev = node.prev;
        }

        private void insert(Node node)
        {
            map.Add(node.key, node);
            Node headNext = head.next;
            head.next = node;
            node.prev = head;
            headNext.prev = node;
            node.next = headNext;
        }
        public class Node
        {
            public Node prev, next;
            public int key, value;

            public Node(int _key, int _value)
            {
                key = _key;
                value = _value;
            }
        }
    }
}
