using System;
using System.Collections.Generic;
using System.Text;

namespace CircularlyDoublyLinkedList
{
    class LinkedList<T>
    {
        Node<T> Head;
        Node<T> Tail; 

        public void AddFirst(T value)
        {
            if (Head == null)
            {
                Head = new Node<T>(value);
                return;
            }

            Node<T> Temp = new Node<T>(value);

            if (Tail == null)
            {
                Tail = Head;
            }
        }


        public void AddLast()
        {

        }

        public void AddBefore()
        {

        }

        public void AddAfter()
        {

        }

        public bool RemoveFirst()
        {
            return false;
        }

        public bool RemoveLast()
        {
            return false;
        }

        public bool Remove(T value)
        {
            return false;
        }

        public bool IsEmpty()
        {
            if (Head == null)
            {
                return true;
            }

            return false;
            
        }
    }
}
