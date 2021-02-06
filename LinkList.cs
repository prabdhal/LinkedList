using System;

namespace LinkedList
{
    static class Node 
    {
        public int value;
        public Node next;
    }

    static class LinkedList
    {
        public Node head;
        public Node tail;
        public static void AddFirst(object data)
        {
            Node newItem = new Node();

            if (head == null)
            {
                head = newItem;
                tail = head;
            }
            else
            {
                newItem.next = head;
                head = newItem;
            }
        }
        public static void AddLast(object data)
        {
            Node newItem = new Node();

            if (head == null)
            {
                head = newItem;
                tail = head;
            }
            else
            {
                tail.next = newItem;
                newItem = tail;
            }
        }
        public static void ReadAll()
        {
            Node node = head;

            Console.WriteLine(node.value);
            while (node.next != null)
            {
                node = node.next;
                Console.WriteLine(node.value);
            }
        }
        public static void ReturnCount()
        {
            Node node = head;
            int count = 0;

            if (node == null) count = 0;
            else count = 1;
                
            while (node.next != null)
            {
                node = node.next;
                count++;
            }

            Console.WriteLine(count);
        }
    }
}

