using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._14.Task2
{
    class CustomQueueObject
    {
        int _position = -1;
        object[] _data = new object[365];
        DateTime[] dataTimes = new DateTime[365];  
        public void Enqueue(object item) 
        {
            _position++;
            _data[_position] = item;
        }

        public void Dequeue() 
        {
            object buffer = default;
            buffer = _data[1];
            _data[0] = buffer;
            _data[1] = null;
        }

        public void Peek()
        {
            foreach (var item in _data)
            {
                if(item != null)
                    Console.WriteLine(item);
            }
        }
    }
}
