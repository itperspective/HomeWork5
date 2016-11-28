using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public class MyQueue
    {
        private int[] array;
        private int head;
        private int count;
        private int tail;


        public MyQueue(int[] Array)
        {
            this.array = Array;
            this.head = 0;
            this.count = 0;
            this.tail = 0;
        }

        public void Enqueue(int enqueue)
        {
            array[head] = enqueue;
            if (head < array.Length - 1)
            {
                head = head + 1;
            }

            else
            {
                head = 0;
            }

            count = count + 1;
        }

        public int Dequeue()
        {
            Console.WriteLine("Poped: " + array[tail]);

            if (tail < array.Length - 1)
            {
                tail = tail + 1;
            }

            else
            {
                tail = 0;
            }

            count = count - 1;

            return tail;
        }

        public bool IsEmpty()
        {
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFull()
        {
            if (head == tail & count != 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
