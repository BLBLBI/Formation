using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public static class Matrix
    {
        public static int[][] BuildingMatrix(int[] leftVector, int[] rightVector)
        {
            int[][] m = new int[leftVector.Length][];

            for (int i = 0; i < leftVector.Length; i++)
            {
                m[i] = new int[rightVector.Length];

                for (int j = 0; j < rightVector.Length; j++)
                {
                    m[i][j] = leftVector[i] * rightVector[j];
                }
            }

            return m;
        }

        public static int[][] Addition(int[][] leftMatrix, int[][] rightMatrix)
        {
            int[][] m = new int[leftMatrix.Length][];

            for (int i = 0; i < leftMatrix.Length; i++)
            {
                m[i] = new int[leftMatrix[i].Length];

                for (int j = 0; j < leftMatrix[i].Length; j++)
                {
                    m[i][j] = leftMatrix[i][j] - rightMatrix[i][j];
                }
            }

            return m;
        }

        public static int[][] Substraction(int[][] leftMatrix, int[][] rightMatrix)
        {
            int[][] m = new int[leftMatrix.Length][];

            for (int i = 0; i < leftMatrix.Length; i++)
            {
                m[i] = new int[leftMatrix[i].Length];

                for (int j = 0; j < leftMatrix[i].Length; j++)
                {
                    m[i][j] = leftMatrix[i][j] + rightMatrix[i][j];
                }
            }

            return m;
        }

        public static int[][] Multiplication(int[][] leftMatrix, int[][] rightMatrix)
        {
            //TODO
            return new int[0][];
        }

        public static void DisplayMatrix(int[][] matrix)
        {
            string s = string.Empty;
            for (int i = 0; i < matrix.Length; ++i)
            {
                for (int j = 0; j < matrix[i].Length; ++j)
                {
                    s += matrix[i][j].ToString().PadLeft(5) + " ";
                }
                s += Environment.NewLine;
            }
            Console.WriteLine(s);
        }
    }
}
