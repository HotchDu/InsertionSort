using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 23, 44, 3, 76, 98, 11, 66, 9, 7 };
            Console.WriteLine("需要排序的数组为：");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            //插入排序：每步将一个待排序的记录，按其关键码值的大小插入前面已经排序的文件中适当位置上，直到全部插入完为止。
            //将第一个视为一个数组，后面的数依次插入；从后向前比较比较；
            for (int i = 1; i < arr.Length; i++)
            {
                int inserValue = arr[i]; //待插入的元素
                int inserIndex = i - 1;  //要插入的位置
                while(inserIndex >= 0 && inserValue < arr[inserIndex])
                {

                    arr[inserIndex + 1] = arr[inserIndex];
                    inserIndex--;  //位置前移
                }
                arr[inserIndex + 1] = inserValue;
            }

            Console.WriteLine("排序后的数组为：");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
