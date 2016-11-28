using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public class MyStack
    {
        private int[] array;
        public MyStack(int[] Array)
        {
            this.array = Array;
            this.top = Array.Length;
        }

        private int top;
        
        public int Pop()
        {
            
            Console.WriteLine("Pop from stack:");
            top = top - 1;
            return array[top];
            

        }

        public void Push (int push)
        {
            array[top + 1] = push;
            top = top + 1;
        }

        public bool IsEmpty()
        {
            if (top == 0)
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
            if (top == array.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Peek()
        {
            return array[top];
        }
    }
}
