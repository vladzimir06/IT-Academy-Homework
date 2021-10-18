using System;

namespace HW._05.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = null;
            Console.WriteLine("Enter size arr: ");
            int size = Convert.ToInt32(Console.ReadLine());
            arr = new int[size];
            for (int i = 0; i < size - 1; i++)
            {
                Console.Write($"Enter {i} element: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{arr[i]} ");  
            }

            Console.WriteLine("\nEnter a new element and index of array: ");
            int el = Convert.ToInt32(Console.ReadLine());
            int index = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 0; i < size; i++)
            {
                if (i == index)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    for (int j = (arr.Length - 1); j >= i + 1; j--) 
                    {                        
                        arr[j] = arr[j - 1];
                    }
                    arr[i] = el;
                    break;
                   
                }
            }
            
            for (int i = 0; i < size; i++) {
               Console.Write($"{arr[i]} ");
            }

        }
    }
}
