using System;

namespace CircularlyDoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {


            LinkedList<int> linkedList = new LinkedList<int>();
            Random gen = new Random();



            //int value;
            //for (int i = 0; i < 10; i++)
            //{
            //    value = gen.Next(1, 100);
            //    Console.WriteLine(value);

            //    linkedList.AddLast(value);

            //}

            //;


            int value;
            for (int i = 0; i < 5; i++)
            {
                value = (i * 100);

                linkedList.AddFirst(value);

            }

            ;

        }
    }
}
