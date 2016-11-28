using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {

            int size = 0;




            Console.WriteLine("Please Enter array size:");
            while(!Int32.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Please Enter int:");
            }

            int[] array = new int[size];
           


            Console.WriteLine("Please enter array values:");
            for (int i=0; i<array.Length; i++)
            {
                while(!Int32.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Please Enter int");
                }
            }

            BubbleSorter BubleSort = new BubbleSorter(array);
            InsertionSorter InsertSort = new InsertionSorter(array);
            MyStack Stack = new MyStack(array);

            //BubleSort.Sort();
            //BubleSort.Print();

            //InsertSort.Sort();
            //InsertSort.Print();

            //Console.WriteLine(Stack.Pop());
        

            Console.ReadLine();

        }

    }
}
