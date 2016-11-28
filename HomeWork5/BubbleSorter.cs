using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public class BubbleSorter
    {

        private int swap;
       // private int size;


        private int[] array;

        public BubbleSorter(int[] Array)
        {
            this.array = Array;
            //Sort(this.array);
            //Print(this.array);

        } 

        //public BubleSorter(int[] Array, int swap)
        //{
        //    this.array = Array;
        //    array[0] = swap;
        //}





       public void Sort ()
        {
            for (int i = 0; i < (array.Length - 1); i++)
            {
                if (array[i + 1] < array[i])
                {
                    Swap(i, i + 1);
                    i = -1;
                }
            }
        }

       public void Swap (int swap1, int swap2)
        {
            swap = array[swap1];
            array[swap1] = array[swap2];
            array[swap2] = swap;
        }

        public void Print()
        {
            Console.Write("[");
            for (int i=0; i<array.Length; i++)
            {
                Console.Write(" " + array[i] + " ");
            }
            Console.Write("]");
        }



    }
}
 