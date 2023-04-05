using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_5_3_13
{
    class Program
    {     
        static int[] SortArrayAsc(int[] array)
        {
            int number = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        number = array[i];
                        array[i] = array[j];
                        array[j] = number;
                    }
                }
            }
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            return array;
        }
        static int[] SortArrayDesc(int[] array)
        {
            int number = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        number = array[i];
                        array[i] = array[j];
                        array[j] = number;
                    }
                }
            }
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            return array;
        }
        static void SortArray(int[] array, out int[] sorteddesc, out int[] sortedasc)
        {
            sorteddesc = SortArrayDesc(array);
            sortedasc = SortArrayAsc(array);        
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 4, 3, 2 };

            SortArray(array, out int[] sorteddesc, out int[] sortedasc);

            Console.ReadKey();
        }
    }
}
