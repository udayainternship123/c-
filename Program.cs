using System;
namespace BubbleSortInCSharp
{
    class bubblesort
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 2, 5, 4, 1 }; // ing numbers through array 
            int t;
            for (int p = 0; p <= a.Length - 2; p++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                }
            }
            Console.WriteLine("This Application Created by vithal wadje for C# corner");
            Console.WriteLine("The Sorted array");
            foreach (int aa in a)                         //writting array
                Console.Write(aa + " ");
            Console.Read();
        }
    }
}



