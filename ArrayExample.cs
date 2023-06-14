using System;
namespace Fundamentals
{
    public class ArrayExample
    {
        public void singleDimentionArrayshow(int[] arr)
        {
            Console.WriteLine("Array is in action: ");

            foreach (int item in arr)
            {
                Console.WriteLine("Array items are: " + item);
            }
        }

        public void TwoDimentionArrayshow(int[,] TwoDArr)
        {
            Console.WriteLine("Two Dimentional Array is in action: ");

            Console.WriteLine("Array Length is: " + TwoDArr.Length);

            Console.WriteLine("Array range for TwoDimentional Array is: " + Math.Log2(TwoDArr.Length));

            /* for (int i = 0; i < TwoDArr.GetLength(0); i++)
             {
                 for (int j = 0; j < TwoDArr.GetLength(1); j++)
                 {
                     Console.Write(TwoDArr[i, j] + " ");
                 }
                 Console.WriteLine();
             }*/

            for (int i = 0; i < Math.Log2(TwoDArr.Length); i++)
            {
                for (int j = 0; j < Math.Log2(TwoDArr.Length); j++)
                {
                    Console.Write(TwoDArr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void jaggedArray(int[][] jaggedArray)
        {
            Console.WriteLine("Jagged Array is in action: ");

            Console.WriteLine("Array Length is: " + jaggedArray.Length);

            //Console.WriteLine("Array range for TwoDimentional Array is: " + Math.Log2(jaggedArray.Length));

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintArray(int[] arr)
        {
            foreach (Object elem in arr)
            {
                Console.Write(elem + " ");
            }
        }


    }
}

