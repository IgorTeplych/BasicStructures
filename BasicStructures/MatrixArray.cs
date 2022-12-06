using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStructures
{
    public class MatrixArray<T> : IArray<T>
    {

        FactorArray<T> array;
        FactorArray<IArray<T>> arrays;
        public MatrixArray()
        {
            array = new FactorArray<T>();
            arrays = new FactorArray<IArray<T>>();
            arrays.Add(array, 0);
        }
        public int Size { get; private set; }
        public void Add(T item, int index)
        {
            int bigSize = arrays.Factor * arrays.Size;
            if (index >= bigSize)
            {
                VectorArray<T> _array = new VectorArray<T>();
                _array.Add(item, bigSize % arrays.Factor);
                arrays.Add(_array, index / arrays.Factor);
            }
            else
            {
                int indexArays = index / arrays.Factor;
                var newArray = arrays.Get(indexArays);
                if(newArray == null)
                {
                    arrays.Add(new VectorArray<T>(), indexArays);
                    newArray = arrays.Get(indexArays);
                }

                newArray.Add(item, index % arrays.Factor);
            }
        }
         
        public T Remove(int index)
        {
            throw new NotImplementedException();
        }
    }
}
