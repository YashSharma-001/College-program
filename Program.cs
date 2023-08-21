using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Questions
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    ===== Question 1: Write a C# program to find the sum of all elements in an integer array using a loop =====
            int[] arr = { 2, 3, 4, 5, 6, 7, 8, 9, 20, 30 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("the sum of all the elements is " + sum);
            Console.ReadLine();


        //    ===== Question 2: Create a C# program that calculates the average of values in a floating-point array using a loop=====
            float[] arr = { 2, 3, 4, 5, 6, 7, 8, 9, 20, 30 };
            flaot sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            float avg = sum / arr.Length - 1;

            Console.WriteLine("the average of all the elements is " + avg);
            Console.ReadLine();

            //   ===== Question 3:Develop a C# program that finds the largest element in an integer array using a loop and if-else statements. =====



            int[] arr = { 1, 2, 3, 9, 8, 7, 6, 5, 4 };
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Largest element is: " + arr[arr.Length - 1]);
            Console.ReadLine();



        //    ===== Question 4: Write a C# program that counts the number of even and odd elements in an integer array using a loop and if-else statements. =====

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9,20,93,0};
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.WriteLine("All are odd no- " + arr[i]);
                }
                else
                {
                    Console.WriteLine("All are even no- " + arr[i]);
                }
            }
            Console.ReadLine();

        //    ===== Question 5: Implement a C# program that reverses the elements of an integer array using a loop. =====


            int number = 23456789, reverse = 0;
            while (number != 0)
            {
                int remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;
            }
            Console.WriteLine("reverse number is: " + reverse);
            Console.ReadLine();


            //    ===== Question 6:Create a C# program that multiplies each element in an integer array by a specified factor using a loop =====

            int[] arr = { 2, 3, 4, 5, 6, 7, 8, 9, 20, 30 };
            int num = 7;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = num * arr[i];
            }
            Console.WriteLine("New Array = " + arr.ToString());
            Console.ReadLine();

]





            //    ===== Question 7: Write a C# program that searches for a specific value in an integer array using a loop and returns its index if found =====

            int[] arr ={ 3,6,9,2,52,98,73};
            int search = 52;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == search)
                {
                    Console.WriteLine("The index of your search element in the array is " + i);
                }
            }
            int[] arr = { 3, 6, 9, 2, 52, 98, 73 };
            int search = 52;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == search)
                {
                    Console.WriteLine("The index of your search element in the array is " + i);
                }
            }
        //   ===== Question 8: Develop a C# program that finds the second smallest element in an integer array using loops and sorting techniques. =====


            int[] arr = { 1, 2, 3, 9, 8, 7, 6, 5, 4 };
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Second Smallest element is: " + arr[1]);
            Console.WriteLine("Second Largest element is: " + arr[arr.Length - 2]);
            Console.ReadLine();



            //    ===== Question 9: Create a C# program that removes all duplicates from an integer array using loops and additional data structures =====

            int[] arr_1 = { 2, 4, 6, 8, 20, 40, 80, 200 };
            int count = 0;
            for (int i = 0; i < arr_1.Length; i++)
            {
                for (int j = i+1; j < arr_1.Length; j++)
                {
                    if (arr_1[i] != arr_1[j])
                    {
                        count++;
                    }
                }
            }
            int[] arr2 = new int[count];

            for (int i = 0; i < arr_1.Length; i++)
            {
                for (int j = i + 1; j < arr_1.Length; j++)
                {
                    if (arr_1[i] != arr_1[j])
                    {
                        arr2[i] = arr_1[i];
                    }
                }
            }

            Console.ReadLine();



            //    ===== Question 10: Write a C# program that finds the common elements between two integer arrays using loops. =====

            int[] arr_1 = { 2, 4, 6, 8, 20, 40, 80, 200 };
            int[] arr_2 = { 2, 22, 33, 44, 55, 66, 200 };
            Console.Write("Common value between two array is: ");
            for (int i = 0; i < arr_1.Length; i++)
            {
                for (int j = 0; j < arr_2.Length; j++)
                {
                    if (arr_1[i] == arr_2[j])
                    {
                        Console.Write(arr_2[j] + " ");
                    }
                }
            }
            Console.ReadLine();



        }
    }
}
