using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._14.Task2
{
    class CustomQueueGeneric<T>
    {
        int _position = -1;
        T[] _generics = new T[365];
        public void Enqueue(T item)
        {
            _position++;
            _generics[_position] = item;
        }

        public void Dequeue()
        {
            T buffer = default;
            buffer = _generics[1];
            _generics[0] = buffer;
            _generics[1] = default;
        }

        public void Peek()
        {
            foreach (var item in _generics)
            {
                if (item != null)
                    Console.WriteLine(item);
            }
        }
    }
}
