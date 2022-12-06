using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStructures
{
    public class FactorArray<T> : IArray<T>
    {
        int factor = 2;
        T[] array;
        public FactorArray()
        {
            array = new T[0];
        }

        public int Factor
        {
            get { return factor; }
        }
        public int Size { get { return array.Length; } }

        public void Add(T item, int index)
        {
            while (index >= array.Length)
            {
                Resize();
            }
            array[index] = item;
        }
        public T Remove(int index)
        {
            T[] tempArray = new T[array.Length - 1];

            long count = 0;
            while (count < index)
            {
                tempArray[count] = array[count];
                count++;
            }
            while (count++ < tempArray.Length)
            {
                tempArray[count - 1] = array[count];
            }

            T outVal = array[index];
            array = tempArray;
            return outVal;
        }
        public T Get(int index)
        {
            return array[index];
        }
        void Resize()
        {
            T[] tempArray = new T[array.Length * factor + 1];

            for (long i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            array = tempArray;
        }
    }
}
