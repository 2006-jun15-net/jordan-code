using System;

namespace PanelPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quick Sort!");
            int[] array = {30,9,7,5,6,27, 100, 6, 12, 13};
            foreach(var item in array)
            {
                Console.WriteLine($"Unsorted Element: {item}");
            }
            Console.WriteLine(" ");
            QuickSort(array, 0, array.Length -1);
            foreach (var item in array)
            {
                Console.WriteLine($"Sorted Element: {item}");
            }

            
        }

        public static void QuickSort(int[] arr, int left, int right)
        {
            if(left < right)
            {
                int pivot = Partition(left, right, arr);
                if(pivot > 1)
                {
                    QuickSort(arr, left, pivot -1);
                }
                if(pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }
            }
        }


        public static int Partition(int left, int right, int[] arr)
        {
            int pivot = arr[left];
            while(true)
            {
                while(arr[left] < pivot)
                {
                    left++;
                }
                while(arr[right] > pivot)
                {
                    right--;
                }
                if(left < right) 
                {
                    if(arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    
                }
                else 
                {
                    return right;
                }
            }
        }
    }
}
