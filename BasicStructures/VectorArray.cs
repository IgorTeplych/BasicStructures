using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStructures
{
    public class VectorArray<T> : IArray<T>
    {
        int vector = 8;
        T[] array;
        public VectorArray()
        {
            array = new T[1];
        }
        public int Vector
        {
            get { return vector; }
        }
        public int Size { get { return array.Length; } }

        public void Add(T item, int index)
        {
            while(index >= array.Length)
            {
                Resize();
            }
            array[index] = item;
        }
        public T Get(int idx)
        {
            return array[idx];
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

        void Resize()
        {
            T[] tempArray = new T[array.Length + vector];

            for (long i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            array = tempArray;
        }
    }
}
