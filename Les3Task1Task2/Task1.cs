using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les3Task1Task2
{
    public class Task1
    {
        public static void DisplayArray(int[] arr) => Console.WriteLine(string.Join(" ", arr));
        public static void ChangeArray(int[] arr, int direction)
        {
            if (direction == 1)
            {
                Array.Sort(arr);
            }
            else if (direction == 2)
            {
                Array.Sort(arr);
                Array.Reverse(arr);
            }
        }
       public static void CheckSortArray(int[] arr, int direction)
        {
            int[] newArray = new int[arr.Length];
            arr.CopyTo(newArray, 0);

            if (direction == 1)
            {
                bool a = false;
                Array.Sort(newArray);
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != newArray[i])
                    {
                        Console.WriteLine("Массив НЕ отсортирован по возратсанию");
                        a = true;
                        break;
                    }
                }
                if (a == false)
                {
                    Console.WriteLine("Массив отсортирован по возратсанию");
                }


            }
            if (direction == 2)
            {
                bool a = false;
                Array.Sort(newArray);
                Array.Reverse(newArray);
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != newArray[i])
                    {
                        Console.WriteLine("Массив НЕ отсортирован по убыванию");
                        a = true;
                        break;
                    }
                }
                if (a == false)
                {
                    Console.WriteLine("Массив отсортирован по убыванию");
                }
            }
        }
        enum Sort : int { UP = 1, DOWN = 2 };
        public static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 5, 7, 3, 6 };
            int x = (int)Sort.UP;
            int y = (int)Sort.DOWN;
            ChangeArray(arr1, x);
            DisplayArray(arr1);
            Console.WriteLine();

            CheckSortArray(arr1, x);
        }
    }
}
