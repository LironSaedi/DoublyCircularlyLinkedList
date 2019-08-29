using System;
using System.Collections.Generic;
using System.Text;

namespace CircularlyDoublyLinkedList
{
    class LinkedList<T> where T : IComparable<T>
    {
        public Node<T> Head;
        Node<T> Tail;
        int count = 0;
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

            count++;
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
            count++;
        }

        public void AddBefore(T value, Node<T> node)
        {

            if (Head == null)
            {
                Head = new Node<T>(value);
                Tail = Head;
                Head.Next = Tail;
                Tail.Next = Head;
                Head.Previous = Tail;
                count++;
                return;

            }

            Node<T> current = new Node<T>(value);


            Node<T> Temp = Head;


            for (int i = 0; i < count; i++)
            {
                if (Temp == node)
                {
                    break;
                }
                Temp = Head.Next;

            }

            current.Next = Temp;
            current.Previous = Temp.Previous;
            Temp.Previous.Next = current;
            Temp.Previous = current;


            count++;
        }

        public void AddAfter(T value, Node<T> node)
        {
            if (Head == null)
            {
                Head = new Node<T>(value);
                Tail = Head;
                Head.Next = Tail;
                Tail.Next = Head;
                Head.Previous = Tail;
                count++;
                return;
            }

            Node<T> current = new Node<T>(value);

            Node<T> Temp = Head;

            for (int i = 0; i < count; i++)
            {
                if (Temp == node)
                {
                    break;
                }

                Temp = Head.Next;
            }

            current.Next = Temp.Next;
            current.Previous = Temp;
            Temp.Next.Previous = current;
            Temp.Next = current;

            count++;
        }

        public bool RemoveFirst()
        {
            if (Head == null)
            {
                return false;
            }

            if (count == 1)
            {
                Head = null;

                count--;
                return true;
            }

            Head.Next = Head;

            Head.Previous = Tail;

            Tail.Next = Head;

            return true;

        }

        public bool RemoveLast()
        {

            if (Head == null)
            {
                return false;
            }



            Tail.Previous = Tail;
            Tail.Next = Head;
            Head.Previous = Tail;

            Tail = null;
            count--;
            return true;





        }

        public bool Remove(T value)
        {
            if (Head == null)
            {
                return false;
            }

            Node<T> current = Head;

            for (int i = 0; i < count; i++)
            {
                if (current.Value.CompareTo(value) == 0)
                {
                    // this is the node you want to remove
                    if (current == Head)
                    {
                        RemoveFirst();
                    }
                    if (current == Tail)
                    {
                        RemoveLast();
                    }

                    current.Next = null;
                    current.Previous = null;
                    current = null;
                    count--;
                    break;
                }

                current = current.Next;
            }

            return true;
        }

        public bool IsEmpty()
        {
            if (Head == null)
            {
                return true;
            }

            return false;
        }


        public int Count()
        {
            return count;
            
        }
    }
}
