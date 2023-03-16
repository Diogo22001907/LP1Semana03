using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[4] {0, 1, 2, 3 };
            matrix[1] = new int[2] {4, 5};
            matrix[2] = new int[3] {6, 7, 8};

            int valor = matrix[0][3];
            Console.WriteLine(valor);
        }
    }
}
