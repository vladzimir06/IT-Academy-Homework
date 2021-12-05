using System;

namespace HW._14.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomQueueObject customQueue = new CustomQueueObject();
            customQueue.Enqueue("1");
            customQueue.Enqueue("2");
            customQueue.Dequeue();
            customQueue.Peek();

            CusnomQueueDate customQueueDate = new CusnomQueueDate();
            customQueueDate.Enqueue(DateTime.Today);
            customQueueDate.Enqueue(DateTime.Now);
            customQueueDate.Dequeue();
            customQueueDate.Peek();


        }
    }
}
