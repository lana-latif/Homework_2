using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Homework_2_Sol
    {
        static int ternarySearch(int l, int r, int key, int[] ar)
        {
            if (r >= l)
            {

                int mid1 = l + (r - l) / 3;
                int mid2 = r - (r - l) / 3;

                if (ar[mid1] == key)
                {
                    return mid1;
                }
                if (ar[mid2] == key)
                {
                    return mid2;
                }

                if (key < ar[mid1])
                {

                    return ternarySearch(l, mid1 - 1, key, ar);
                }
                else if (key > ar[mid2])
                {

                    return ternarySearch(mid2 + 1, r, key, ar);
                }
                else
                {
                    return ternarySearch(mid1 + 1, mid2 - 1, key, ar);
                }
            }
            return -1;
        }

        static int countSearch(int[] ar,int key)
        {
            int count = 0;
            foreach (int i in ar)
            {
                if (i == key)
                    count++;
            }
            return count;
        }

        public static void Main()
        {

            // -------------------------- 1 ---------------------------------
            int l, r, p, key;
            int[] ar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            l = 0;
            r = 9;
            // Checking for 5
            key = 5;
            p = ternarySearch(l, r, key, ar);
            Console.WriteLine("Index of " + key + " is " + p);

            // Checking for 50
            key = 50;
            p = ternarySearch(l, r, key, ar);
            Console.WriteLine("Index of " + key + " is " + p);

            Console.WriteLine("\n\n-----------------------------------\n\n");
            // -------------------------- 2 ---------------------------------
            int[] arr = { 5, 4, 2, 5, 7, 0, 5, 7, 8, 9 };
            key = 5;
            int count=countSearch(arr, key);
            Console.WriteLine($"Count of key {key} is {count}");
        }
    }
}
