using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT481_Satterfield_Unit7Algorithm1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine();
            Console.WriteLine("*****Section 1 - Bubble Sort Small Data Set *****");
            Console.WriteLine();
            Program bubble = new Program();
            int[] studentGrades = { 65, 95, 75, 55, 56, 90, 88, 97, 78, 100 };


            Console.WriteLine("The unsorted list of grades in,");
            bubble.printArray(studentGrades);
            bubble.sortArrayDescBS(studentGrades);
            Console.WriteLine("The  10 grades in descending order are,");
            bubble.printArray(studentGrades);
            bubble.sortArrayAscBS(studentGrades);
            Console.WriteLine("The 10 grades in ascending order are,");
            bubble.printArray(studentGrades);
          
            Console.WriteLine();
            Console.WriteLine("*****Section 2 - Bubble Sort Medium Size Data Set *****");
            Console.WriteLine();
            Program bubble2 = new Program();
            int[] studentGrades2 = { 65, 95, 75, 55, 56, 90, 88, 97, 78, 74, 45, 67, 87, 94, 92, 99, 83, 84, 78, 74, 73, 99, 98, 96, 95, 88, 77, 86, 55, 64, 78, 92, 93, 67, 78, 84, 63, 42, 56, 71, 88, 75, 89, 92, 93, 98, 92, 80, 70, 90 };


            Console.WriteLine("The unsorted list of grades in,");
            bubble.printArray(studentGrades2);
            bubble.sortArrayDescBS(studentGrades2);
            Console.WriteLine("The 50 grades in descending order are,");
            bubble.printArray(studentGrades2);
            bubble.sortArrayAscBS(studentGrades2);
            Console.WriteLine("The 50 grades in ascending order are,");
            bubble.printArray(studentGrades2);
           
            Console.WriteLine();
            Console.WriteLine("*****Section 3 - Bubble Sort Large Size Data Set *****");
            Console.WriteLine();
            Program bubble3 = new Program();
            int[] studentGrades3 = { 38, 40, 81, 75, 55, 89, 43, 76, 84, 62, 70, 91, 82, 79, 61, 89, 93, 50, 60, 59, 48, 67, 65, 85, 79, 95, 77, 78, 66, 86, 49, 48, 72, 86, 57, 71, 82, 93, 95, 89, 41, 82, 73, 90, 52, 66, 76, 82, 90, 55, 65, 95, 75, 55, 56, 90, 88, 97, 78, 74, 45, 67, 87, 94, 92, 99, 83, 84, 78, 74, 73, 99, 98, 96, 95, 88, 77, 86, 55, 64, 78, 92, 93, 67, 78, 84, 63, 42, 56, 71, 88, 75, 89, 92, 93, 98, 92, 80, 70, 90 };


            Console.WriteLine("The unsorted list of the 100 grades in,");
            bubble.printArray(studentGrades3);
            bubble.sortArrayDescBS(studentGrades3);
            Console.WriteLine("The 100 grades in descending order are,");
            bubble.printArray(studentGrades3);
            bubble.sortArrayAscBS(studentGrades3);
            Console.WriteLine("The 100 grades in ascending order are,");
            bubble.printArray(studentGrades3);

            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write(i);
            }

            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }
        
        public void sortArrayAscBS(int[] x)
        {
            int temp = 0;

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x.Length - 1; j++)
                {
                    if (x[j] > x[j + 1])
                    {
                        temp = x[j + 1];
                        x[j + 1] = x[j];
                        x[j] = temp;
                    }
                }
            }
        }

        public void sortArrayDescBS(int[] x)
        {
            int temp = 0;

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x.Length - 1; j++)
                {
                    if (x[j] < x[j + 1])
                    {
                        temp = x[j + 1];
                        x[j + 1] = x[j];
                        x[j] = temp;
                    }
                }
            }
        }

        public void printArray(int[] x)
        {

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i] + " ");
            }
            Console.WriteLine(" ");
        }

    }

}