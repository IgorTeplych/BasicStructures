using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStructures
{
    internal class Wrap<T> : IArray<T>
    {
        ArrayList arrayList;
        public Wrap()
        {
            arrayList = new ArrayList();
        }
        public void Add(T item, int index)
        {
            arrayList.Add(item);
        }

        public T Remove(int index)
        {
            throw new NotImplementedException();
        }
    }
}
