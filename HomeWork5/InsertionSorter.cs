using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public class InsertionSorter
    {
        
        private int swap;
        private int[] array;

        public InsertionSorter(int[] Array)
        {
            this.array = Array;
        }

        public void Sort()
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {

                    Swap(i - 1, i);

                    for (int j = (i - 1); j > 0; j--)
                    {
                        if (array[j] < array[j - 1])
                        {
                            Swap(j - 1, j);
                        }

                        else
                        {
                            break;
                        }
                    }

                }

            }
        }
        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i] + " ");
            }
            Console.Write("]");
        }

        public void Swap(int swap1, int swap2)
        {
            swap = array[swap1];
            array[swap1] = array[swap2];
            array[swap2] = swap;
        }
    }
}
