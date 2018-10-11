using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesLaboratory
{
    class MatrixClass
    {
        public const int COUNT_ROWS = 15;
        public const int COUNT_COLUMNS = 15;

        int rows, cols;
        double[,] matrix;

        public MatrixClass(int rows = COUNT_ROWS, int cols = COUNT_COLUMNS)
        {
            this.cols = cols; this.rows = rows;
            matrix = new double[rows, cols];
        }

        public double this[int indexRows, int indexCols]
        {
            get
            {
                return matrix[indexRows, indexCols];
            }

            set
            {
                matrix[indexRows, indexCols] = value;
            }
        }

        public int Rows
        {
            get { return rows; }
        }

        public int Columns
        {
            get { return cols; }
        }

        public static implicit operator MatrixClass(int[,] rhs)
        {
            MatrixClass additionalMatrix = new MatrixClass();
            for (int i = 0; i < additionalMatrix.Rows; i++)
            {
                for (int j = 0; j < additionalMatrix.Columns; j++)
                {
                    additionalMatrix[i, j] = rhs[i, j];
                }
            }
            return additionalMatrix;
        }

        public void AddRows(int rowAdd, int rowRes)
        {
            for(int j = 0; j < cols; j++)
            {
                matrix[rowRes, j] += matrix[rowAdd, j];
            }
        }

        public void DivideRow(int row, double val)
        {
            for(int j = 0; j < cols; j++)
            {
                matrix[row, j] /= val;
            }
        }

        public void MultiplyRow(int row, double val)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[row, j] *= val;
            }
        }
    }
}
