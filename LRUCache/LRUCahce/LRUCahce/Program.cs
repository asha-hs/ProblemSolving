using System;

namespace LRUCahce
{
    class Program
    {
        static void Main(string[] args)
        {
            LRUCache cache = new LRUCache(2);

            cache.Set(1, 2);
            cache.Set(2, 3);
            Console.WriteLine(cache.Get(1));
            cache.Set(3, 4);
            Console.WriteLine(cache.Get(2));  // should return -1 because Least recently used key so removed
        }
    }
}
