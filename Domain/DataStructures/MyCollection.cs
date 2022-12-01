using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataStructures
{
    internal class MyCollection<T>
    {
        private const int genericSize = 20;
        private T[] array = new T[genericSize];


        public MyCollection(List<T> elements, int size = genericSize)
        {
            if (size != genericSize)
            {
                array = new T[size];
            }
            int index = 0;
            foreach(T element in elements)
            {
                array[index] = element;
            }

        }
        public T GetItem(int index)
        {
            return array[index];
        }

        public void SetItem(int index, T value)
        {
            array[index] = value;
        } 
        public void Swap(int index1, int index2)
        {   T aux = array[index1];
            array[index1] = array[index2];
            array[index2] = aux;
        }
    }
}
