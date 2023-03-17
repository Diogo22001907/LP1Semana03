using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Solicite ao utilizador a dimensão horizontal e vertical de um array
            bidimensional de floats

            Para cada posição i,j do array, solicitar um número real ao utilizador e
            guarda-lo na respetiva posição do array

            Calcule a soma dos valores em cada linha e as apresente no ecrã

            Calcule a soma dos valores em cada coluna e a apresente no ecrã
            */

            Console.WriteLine("Please enter how many collums do you want : ");
            int columns_inputs = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter how many rows do you want : ");
            int rows_input = int.Parse(Console.ReadLine());

            float[,] array_sums = new float[rows_input, columns_inputs];

            for (int row = 0; row < rows_input; row++)
            {
                for (int columns = 0; columns < columns_inputs; columns++)
                {
                    Console.WriteLine("Enter a float value for row {0} and column {1}: ", row, columns);
                    float value = float.Parse(Console.ReadLine());
                    array_sums[row, columns] = value;
                }
            }

            for (int columns = 0; columns < columns_inputs; columns++)
            {
                float sum = 0;
                for (int row = 0; row < rows_input; row++)
                {
                    sum += array_sums[row, columns];
                }
                Console.WriteLine("Sum of column {0}: {1}", columns, sum);
            }

            for (int row = 0; row < rows_input; row++)
            {
                float sum = 0;
                for (int columns = 0; columns < columns_inputs; columns++)
                {
                    sum += array_sums[row, columns];
                }
                Console.WriteLine("Sum of row {0}: {1}", row, sum);
            }
        }
    }
}





