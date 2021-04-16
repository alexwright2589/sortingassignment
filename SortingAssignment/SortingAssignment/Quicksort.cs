﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAssignment
{
    public class Quicksort
    {

        public int[] QuickSort(int[] data)
        {
            Quick_Sort(data, 0, data.Length - 1);
            return data;
        }  
        public void Quick_Sort(int[] data, int left, int right)
        {
            int i, j;
            int pivot, temp;

            i = left;
            j = right;
            pivot = data[(left + right) / 2];
            {
                while ((data[i] < pivot) && (i < right)) i++;
                while ((pivot < data[j]) && (j > left)) j--;

                if (i <= j)
                {
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j) ;
            
            if (left < j) Quick_Sort(data, left, j);
            if (i < right) Quick_Sort(data, i, right);

        }
    }
}
