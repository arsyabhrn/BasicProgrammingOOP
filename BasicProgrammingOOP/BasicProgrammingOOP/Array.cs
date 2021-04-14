using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingOOP
{
    class Array
    {
        public int size;

        public Array(int aSize)
        {
            size = aSize;
            int[] intArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Masukkan angka index ke-{i}");
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = intArray.Sum();
            Console.WriteLine($"jumlah dari array adalah {sum}");
        }
    }
}
