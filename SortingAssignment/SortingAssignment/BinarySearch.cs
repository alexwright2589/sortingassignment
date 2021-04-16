using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAssignment
{
    public class BinarySearch
    {
        static int BinarySearch_R(int key, int[] array, int low, int high)
        {
            if (low > high) return -1;
            int mid = (low + high) / 2;
            if (key == array[mid])
            {
                return mid;
            }
            if (key < array[mid])
            {
                return BinarySearch_R(key, array, low, mid - 1);
            }
            else
            {
                return BinarySearch_R(key, array, mid + 1, high);
            }






        }


    }
}
