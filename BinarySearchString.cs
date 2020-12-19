using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    partial class BT
    {
        public static int BinarySearch(string[] inputData, string searchKey)
        {
            int min = 0;
            int max = inputData.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                int res = searchKey.CompareTo(inputData[mid]);

                if (res == 0)
                {
                    return ++mid;
                }
                else if (res > 0)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }

            return -1;
        }
    }
}
