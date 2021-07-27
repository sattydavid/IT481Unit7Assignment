using System;

namespace IT481_Satterfield_Unit7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("*****Section 1 - Bubble Sort *****");
            Console.WriteLine();
            Program bubble = new Program();
            int[] studentGrades = { 65, 95, 75, 55, 56, 90, 88, 97, 78, 99 };

            Console.WriteLine("The unsorted list of grades in,");
            bubble.printArray(studentGrades);
            bubble.sortArrayDescBS(studentGrades);
            Console.WriteLine("The grades in descending order are,");
            bubble.printArray(studentGrades);
            bubble.sortArrayAscBS(studentGrades);
            Console.WriteLine("The grades in ascending order are,");
            bubble.printArray(studentGrades);



            Console.WriteLine();
            Console.WriteLine("*******Section 1- Quick Sort- Small Datat *****");
            Console.WriteLine();
            Program quick = new Program();

            quick.sortArrayDescQS(studentGrades, 0, 10);
            Console.WriteLine("The grades in descending order are,");
            quick.printArray(studentGrades);
            Console.WriteLine();
            Console.WriteLine("*****Section 2 - Bubble Sort Medium Size Data Set *****");
            Console.WriteLine();
            Program bubble2 = new Program();
            int[] studentGrades2 = { 65, 95, 75, 55, 56, 90, 88, 97, 78, 74, 45, 67, 87, 94, 92, 99, 83, 84, 78, 74, 73, 99, 98, 96, 95, 88, 77, 86, 55, 64, 78, 92, 93, 67, 78, 84, 63, 42, 56, 71, 88, 75, 89, 92, 93, 98, 92, 80, 70, 90};


            Console.WriteLine("The unsorted list of grades in,");
            bubble.printArray(studentGrades2);
            bubble.sortArrayDescBS(studentGrades2);
            Console.WriteLine("The 50 grades in descending order are,");
            bubble.printArray(studentGrades2);
            bubble.sortArrayAscBS(studentGrades2);
            Console.WriteLine("The 50 grades in ascending order are,");
            bubble.printArray(studentGrades2);

            quick.sortArrayAscQS(studentGrades, 0, 10);
            Console.WriteLine("The grades in ascending order, ");
            quick.printArray(studentGrades);
            Console.WriteLine();
            Console.WriteLine("*******Section 2- Quick Sort- Medium Size Data size *****");
            Console.WriteLine();
            Program quick2 = new Program();

            quick.sortArrayDescQS(studentGrades2, 0, 50);
            Console.WriteLine("The 50  grades in descending order are,");
            quick.printArray(studentGrades2);

            quick.sortArrayAscQS(studentGrades2, 0, 25);
            Console.WriteLine("The 50 grades in ascending order, ");
            quick.printArray(studentGrades2);

            Console.WriteLine();
            Console.WriteLine("*****Section 3 - Bubble Sort Large Size Data Set *****");
            Console.WriteLine();
            Program bubble3 = new Program();
            int[] studentGrades3 = { 38, 40, 81, 75, 55, 89, 43, 76, 84, 62, 70, 91, 82, 79, 61, 89, 93, 50, 60, 59, 48, 67, 65, 85, 79, 95, 77, 78, 66, 86, 49, 48, 72, 86, 57, 71, 82, 93, 95, 89, 41, 82, 73, 90, 52, 66, 76, 82, 90, 55, 65, 95, 75, 55, 56, 90, 88, 97, 78, 74, 45, 67, 87, 94, 92, 99, 83, 84, 78, 74, 73, 99, 98, 96, 95, 88, 77, 86, 55, 64, 78, 92, 93, 67, 78, 84, 63, 42, 56, 71, 88, 75, 89, 92, 93, 98, 92, 80, 70, 90 };


            Console.WriteLine("The unsorted list of the 50 grades in,");
            bubble.printArray(studentGrades3);
            bubble.sortArrayDescBS(studentGrades3);
            Console.WriteLine("The 100 grades in descending order are,");
            bubble.printArray(studentGrades3);
            bubble.sortArrayAscBS(studentGrades3);
            Console.WriteLine("The 100 grades in ascending order are,");
            bubble.printArray(studentGrades3);

            Console.WriteLine();
            Console.WriteLine("*******Section 3- Quick Sort- Large Data Set *****");
            Console.WriteLine();
            Program quick3 = new Program();

            quick.sortArrayDescQS(studentGrades3, 0, 100);
            Console.WriteLine("The grades in descending order are,");
            quick.printArray(studentGrades3);

            quick.sortArrayAscQS(studentGrades3, 0, 100);
            Console.WriteLine("The grades in ascending order, ");
            quick.printArray(studentGrades3);

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

        public void sortArrayDescQS(int[] x, int low, int high)
        {
            if (x == null || x.Length == 0)
                return;
            if (low >= high)
                return;

            int middle = low + (high - low) / 2;
            int pivot = x[middle];

            int i = low, j = high;
            while (i <= j)
            {
                while (x[i] > pivot)
                {
                    i++;
                }


                while (x[j] < pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = x[i];
                    x[i] = x[j];
                    x[j] = temp;
                    i++;
                    j--;
                }
            }



            if (low < j)
                sortArrayDescQS(x, low, j);
            if (high > i)
                sortArrayDescQS(x, i, high);
        }

        public void sortArrayAscQS(int[] x, int low, int high)
        {
            if (x == null || x.Length == 0)
                return;
            if (low >= high)
                return;

            int middle = low + (high - low) / 2;
            int pivot = x[middle];

            int i = low, j = high;
            while (i <= j)
            {
                while (x[i] < pivot)
                {
                    i++;
                }
                while (x[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = x[i];
                    x[i] = x[j];
                    x[j] = temp;
                    i++;
                    j--;
                }
            }
            if (low < j)
                sortArrayAscQS(x, low, j);
            if (high > i)
                sortArrayAscQS(x, i, high);
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
