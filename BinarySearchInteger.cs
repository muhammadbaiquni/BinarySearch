namespace BinarySearch
{
    partial class BT
    {
        public static int BinarySearch (int[] inputData, int searchKey)
        {
            int min = 0;
            int max = inputData.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;

                if(searchKey == inputData[mid])
                {
                    return ++mid;
                }
                else if(searchKey < inputData[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return -1;
        }

        public static int BinarySearchRecursive(int[] inputData, int min, int max, int searchKey)
        {
            if(min <= max)
            {
                int mid = (min + max) / 2;

                if(searchKey == inputData[mid])
                {
                    return ++mid;
                }
                else if(searchKey < inputData[mid])
                {
                    BinarySearchRecursive(inputData, min, mid - 1, searchKey);
                }
                else
                {
                    BinarySearchRecursive(inputData, mid + 1, max, searchKey);
                }
            }

            return -1;
        }
    }
}
