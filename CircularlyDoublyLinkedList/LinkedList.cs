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
                Tail = Head;
                Head.Next = Tail;
                Tail.Next = Head;
                Head.Previous = Tail;
                return;
            }
            // creating the node 
            Node<T> Temp = new Node<T>(value);


            Temp.Next = Head;
            Head.Previous = Temp;

            Tail.Next = Temp;
            Temp.Next = Head;
            Head = Temp;
                       

        }


        public void AddLast(T value)
        {
            if (Head == null)
            {
                Head = new Node<T>(value);
                Tail = Head;
                Head.Next = Tail;
                Tail.Next = Head;
                Head.Previous = Tail;
                return;
            }
            // creating the node 
            Node<T> Temp = new Node<T>(value);

            Tail.Next = Temp;
            Temp.Previous = Tail;

            Temp.Next = Head;
            Head.Previous = Tail;

            Tail = Temp;
           
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
