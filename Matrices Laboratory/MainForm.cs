using System;
using System.Windows.Forms;

/// <summary>
/// Преобразовать  заданную двумерную  матрицу вещественных  чисел к верхнему треугольному виду
/// (см.метод Гаусса решения систем линейных алгеб-раических уравнений).
/// Результат оформить в виде ступенчатого массива.
/// </summary>

namespace MatricesLaboratory
{
    public partial class MainForm : Form
    {
        const int RANDOM_BOUND_DOWN = -100;
        const int RANDOM_BOUND_UP = 100;
        const int COUNT_ROW_COL_DEFAULT = 10;

        int[,] baseMatrix;
        MatrixClass individualMatrix;

        bool isProcessedIndividualMatrix = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void BuildMatrixButton_Click(object sender, EventArgs e)
        {
            if(BaseMatrixRadioButton.Checked) FillBaseMatrix_in_DataGridView();
            else FillIndividualMatrix_in_DataGridView();

            isProcessedIndividualMatrix = false;
        }

        private void FillBaseMatrix_in_DataGridView()
        {
            baseMatrix = new int[MatrixClass.COUNT_ROWS, MatrixClass.COUNT_COLUMNS];
            Random rnd = new Random();

            MatrixDataGridView.ColumnCount = MatrixClass.COUNT_COLUMNS;
            MatrixDataGridView.RowCount = MatrixClass.COUNT_ROWS;

            for (int i = 0; i < MatrixClass.COUNT_ROWS; i++)
            {
                for (int j = 0; j < MatrixClass.COUNT_COLUMNS; j++)
                {
                    baseMatrix[i, j] = rnd.Next(RANDOM_BOUND_DOWN, RANDOM_BOUND_UP);
                    MatrixDataGridView.Rows[i].Cells[j].Value = baseMatrix[i, j].ToString();
                }
            }
        }

        private void FillIndividualMatrix_in_DataGridView()
        {
            if (!InitializeIndividualMatrix()) return;
            Random rnd = new Random();

            MatrixDataGridView.ColumnCount = individualMatrix.Columns;
            MatrixDataGridView.RowCount = individualMatrix.Rows;

            for (int i = 0; i < individualMatrix.Rows; i++)
            {
                for (int j = 0; j < individualMatrix.Columns; j++)
                {
                    individualMatrix[i, j] = rnd.Next(RANDOM_BOUND_DOWN, RANDOM_BOUND_UP);
                    MatrixDataGridView.Rows[i].Cells[j].Value = String.Format("{0:0}", individualMatrix[i, j]);
                }
            }
        }

        private bool InitializeIndividualMatrix()
        {
            int cols, rows;
            try
            {
                cols = int.Parse(ColumnsTextBox.Text);
                rows = int.Parse(RowsTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Count of columns or rows is uncorrect. Correct it and try again!");
                return false;
            }

            if (cols == 0 || rows == 0)
            {
                MessageBox.Show("Count of columns or rows is zero. Correct it and try again!");
                return false;
            }

            individualMatrix = new MatrixClass(rows, cols);
            return true;
        }

        private void FillMatrixGridView(int[][] array, string fm = "{0:0}")
        {
            MatrixDataGridView.ColumnCount = individualMatrix.Columns;
            MatrixDataGridView.RowCount = individualMatrix.Rows;

            for (int i = 0; i < individualMatrix.Rows; i++)
            {
                for (int j = 0; j < individualMatrix.Columns - i; j++)
                {
                    MatrixDataGridView[i, j].Value = String.Format(fm, array[i][j]);
                }
            }
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            if (MatrixDataGridView.GetCellCount(DataGridViewElementStates.Displayed) == 0)
            {
                MessageBox.Show("Matrix isn't builded. Correct it and try again!");
                return;
            }
            if (BaseMatrixRadioButton.Checked) ProcessBaseMatrix();
            else ProcessIndividualMatrix();
        }

        private void ProcessBaseMatrix()
        {
            int maxVal = int.MinValue;
            for (int i = 0; i < 15; i++)
                if (baseMatrix[i, 14 - i] > maxVal) maxVal = baseMatrix[i, 14 - i];

            ResultTextBox.Text = maxVal.ToString();
        }

        private void ProcessIndividualMatrix()
        {
            if (isProcessedIndividualMatrix) return;
            if (individualMatrix == null)
            {
                InitializeIndividualMatrix();
                individualMatrix = baseMatrix;
            }

            // --- Gauss method ---
            int minCells = Math.Min(individualMatrix.Columns, individualMatrix.Rows);
            for (int i = 0; i < minCells; i++)
            {
                individualMatrix.DivideRow(i, individualMatrix[i, i]);

                for(int k = i + 1; k < individualMatrix.Rows; k++)
                {
                    double pw = (-1) * individualMatrix[k, i];
                    individualMatrix.MultiplyRow(i, pw);
                    individualMatrix.AddRows(i, k);
                    individualMatrix.DivideRow(i, pw);
                }
            }
            // --- // ---

            double[][] resultArray = new double[individualMatrix.Rows][];
            for(int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = new double[resultArray.Length - i];
            }

            for(int i = 0; i < resultArray.Length; i++)
            {
                for(int j = resultArray[i].Length - 1, k = 0; k < resultArray[i].Length; j--, k++)
                {
                    resultArray[i][j] = individualMatrix[i, j + i];
                }
            }

            MatrixDataGridView.Rows.Clear();
            MatrixDataGridView.ColumnCount = individualMatrix.Columns;
            MatrixDataGridView.RowCount = individualMatrix.Rows;

            for (int i = 0; i < resultArray.Length; i++)
            {
                for (int j = resultArray[i].Length - 1, k = 0; k < resultArray[i].Length; j--, k++)
                {
                    MatrixDataGridView.Rows[i].Cells[j + i].Value = String.Format("{0:0}", resultArray[i][j]);
                }
            }
            isProcessedIndividualMatrix = true;
        }

        private void IndividualMatrixRadioButton_CheckedChanged(object sender, EventArgs e)
        {   

            // If individialMatrixRadioButton is checked
            if(IndividualMatrixRadioButton.Checked)
            {
                // If MatrixDataGridView isn't clear
                if (MatrixDataGridView.GetCellCount(DataGridViewElementStates.Displayed) != 0)
                {
                    ColumnsTextBox.Text = MatrixClass.COUNT_COLUMNS.ToString();
                    RowsTextBox.Text = MatrixClass.COUNT_ROWS.ToString();
                }
                // ... is clear
                else
                {
                    ColumnsTextBox.Text = COUNT_ROW_COL_DEFAULT.ToString();
                    RowsTextBox.Text = COUNT_ROW_COL_DEFAULT.ToString();
                }

                // Set visible group boxes
                ColRowGroupBox.Visible = true;
                ResultGroupBox.Visible = false;
            }
            else
            {
                // Set visible group boxes
                ColRowGroupBox.Visible = false;
                ResultGroupBox.Visible = true;
                individualMatrix = null;
            }
        }
    }
}
