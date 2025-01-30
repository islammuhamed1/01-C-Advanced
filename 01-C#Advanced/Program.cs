namespace _01_C_Advanced
{
    class Program
    {
        static void Main()
        {
            #region BubbleSort

            //int[] arr = { 5, 3, 8, 4, 2 };
            //OptimizedBubbleSort(arr);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i]);
            //    if (i < arr.Length - 1)
            //    {
            //        Console.Write(", ");
            //    }
            //}

            #endregion
            #region Range
            //Range<int> range = new Range<int>(5, 15);
            //Console.WriteLine(range.IsInRange(12));  
            //Console.WriteLine(range.IsInRange(20));  
            //Console.WriteLine(range.Length());      

            //Range<double> doubleRange = new(1.5, 15.5);
            //Console.WriteLine(doubleRange.Length());
            #endregion
            #region Reverse
            //int[] arr = { 1, 2, 3, 4 };
            //ReverseArray(arr);

            //foreach (int num in arr)
            //{
            //    Console.Write(num + ",");
            //}
            #endregion
            #region evennumbers
            //int[] nums = { 1, 2, 3, 4};
            //int[] evens = GetEvenNumbers(nums);

            //for (int i = 0; i < evens.Length; i++)
            //{
            //    Console.Write(evens[i] + ",");
            //}
            #endregion
            #region FixedSizeList
            //FixedSizeList<int> list = new FixedSizeList<int>(-3); 

            //list.Add(50);
            //list.Add(100); 

            //Console.WriteLine("index 0: " + list.Get(0));  
            //Console.WriteLine("index 1: " + list.Get(1));  
            //Console.WriteLine("Total items: " + list.Count());   
            //Console.WriteLine("Capacity: " + list.Capacity());    

            #endregion
            #region Dictionary
            //Console.WriteLine(NoRepeat(str: "IslamI"));
            #endregion


        }
        #region OptimizedBubbleSort
        //static void OptimizedBubbleSort(int[] arr)
        //{
        //    int n = arr.Length;
        //    bool optimized;
        //    for (int i = 0; i < n - 1; i++)
        //    {
        //        optimized = false;
        //        for (int j = 0; j < n - i - 1; j++)
        //        {
        //            if (arr[j] > arr[j + 1])
        //            {
        //                (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
        //                optimized = true;
        //            }
        //        }
        //        if (!optimized)
        //            break;
        //    }
        //}
        #endregion
        #region ReverseArray
        //static void ReverseArray(int[] arr)
        //{
        //    int left = 0, right = arr.Length - 1;
        //    while (left < right)
        //    {
        //        int temp = arr[left];
        //        arr[left] = arr[right];
        //        arr[right] = temp;
        //        left++;
        //        right--;
        //    }
        //}
        #endregion
        #region even
        //static int[] GetEvenNumbers(int[] numbers)
        //{
        //    int count = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] % 2 == 0)
        //        {
        //            count++;
        //        }
        //    }

        //    int[] evens = new int[count];
        //    int index = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] % 2 == 0)
        //        {
        //            evens[index] = numbers[i];
        //            index++;
        //        }
        //    }

        //    return evens;
        //}

        #endregion
        #region 
        #endregion
        #region NoRepeat
        //static int NoRepeat(string str)
        //{
        //    const int ASCI = 256;
        //    int[] charCounts = new int[ASCI];

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        charCounts[str[i]]++;
        //    }

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (charCounts[str[i]] == 1)
        //        {
        //            return i;
        //        }
        //    }

        //    return -1;
        //}
            #endregion

        }
}





