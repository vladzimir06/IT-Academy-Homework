using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._14.Task2
{
    class CusnomQueueDate
    {
        int _position = -1;
        DateTime[] _dataTimes = new DateTime[365];
        public void Enqueue(DateTime item)
        {
            _position++;
            _dataTimes[_position] = item;
        }

        public void Dequeue()
        {
            DateTime buffer = default;
            buffer = _dataTimes[1];
            _dataTimes[0] = buffer;
            _dataTimes[1] = default;
        }

        public void Peek()
        {
            foreach (var item in _dataTimes)
            {
                if (item != default)
                    Console.WriteLine(item);
            }
        }
    }
}
