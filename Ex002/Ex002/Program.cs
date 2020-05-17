using System;

namespace Ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter with of matrix size (enter only one number): ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            Console.WriteLine("Enter the matrix numbers: ");

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);
            Console.ReadKey();
        }
    }
}
