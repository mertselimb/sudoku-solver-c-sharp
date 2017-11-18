using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace yazlab2
{
    public partial class Form1 : Form
    {
        #region Definitions
        public Form1()
        {
            InitializeComponent();
        }
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        int[,] sudokuMatrix1;
        int[,] sudokuMatrix2;
        int[,] sudokuMatrix3;
        int[,] sudokuMatrix4;
        Thread th1;
        Thread th2;
        Thread th3;
        Thread th4;
        #endregion
        #region Clicks
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string sudokuSource = File.ReadAllText(@"C:\sudoku.txt");
            char[] array = sudokuSource.ToCharArray();
            for (int i = 0; i < sudokuSource.Length; i++)
            {
                if (String.Equals('*', sudokuSource[i]))
                {
                    array[i] = '0';
                }
            }

            int[,] matrix = new int[9, 9];
            int index = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    while ((int)Char.GetNumericValue(array[index]) == -1)
                    {
                        index++;
                    };
                    matrix[i, j] = (int)Char.GetNumericValue(array[index]);

                    if (array.Length <= index)
                    {
                        break;
                    }
                    index++;
                }
                if (array.Length <= index)
                {
                    break;
                }
            }

            sudokuMatrix1 = matrix;
            sudokuMatrix2 = matrix;
            sudokuMatrix3 = matrix;
            sudokuMatrix4 = matrix;
            print(0, sudokuMatrix1);
        }
        private void btnSolve_Click(object sender, EventArgs e)
        {
            myTimer.Tick += new EventHandler(printAll);
            myTimer.Interval = 1;
            myTimer.Start();
            th1 = new Thread(solver1);
            th1.Start();
            th2 = new Thread(solver2);
            th2.Start();
            th3 = new Thread(solver3);
            th3.Start();
            th4 = new Thread(solver4);
            th4.Start();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            print(1, sudokuMatrix1);
            print(2, sudokuMatrix2);
            print(3, sudokuMatrix3);
            print(4, sudokuMatrix4);
        }
        #endregion
        #region Print
        private void print(int select, int[,] matrix)
        {
            string output = "";
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    output += matrix[i, j];
                }
            }
            if (select == 0)
            {
                textBox1.Text = output;
                textBox2.Text = output;
                textBox3.Text = output;
                textBox4.Text = output;
            }
            if (select == 1)
            {
                textBox1.Text = output;
            }
            if (select == 2)
            {
                textBox2.Text = output;
            }
            if (select == 3)
            {
                textBox3.Text = output;
            }
            if (select == 4)
            {
                textBox4.Text = output;
            }
        }
        private void printAll(Object myObject, EventArgs myEventArgs)
        {
            print(1, sudokuMatrix1);
            print(2, sudokuMatrix2);
            print(3, sudokuMatrix3);
            print(4, sudokuMatrix4);
        }
        #endregion
        #region Threads
        private void solver1()
        {
            solve(sudokuMatrix1);
        }
        private void solver2()
        {
            solve(sudokuMatrix2);
        }
        private void solver3()
        {
            solve(sudokuMatrix3);
        }
        private void solver4()
        {
            solve(sudokuMatrix4);
        }
        #endregion
        #region Solve sudoku
        private bool isEmpty(int input)
        {
            bool answer = false;
            if (input == 0)
            {
                answer = true;
            }
            return answer;
        }
        private bool solve(int[,] matrix)
        {
            int x = 0;
            int y = 0;
            if (isFull(matrix, ref x, ref y))
                return true;

            for (int num = 1; num <= 9; num++)
            {
                if (isSafe(matrix, x, y, num))
                {
                    matrix[x, y] = num;

                    if (solve(matrix))
                        return true;

                    matrix[x, y] = 0;
                }
            }
            return false;
        }
        //Is there space for more calculations in sudoku
        bool isFull(int[,] matrix, ref int x, ref int y)
        {
            for (x = 0; x < 9; x++)
                for (y = 0; y < 9; y++)
                    if (matrix[x, y] == 0)
                        return false;
            return true;
        }
        //Looks at x
        bool UsedInRow(int[,] matrix, int x, int num)
        {
            for (int y = 0; y < 9; y++)
                if (matrix[x, y] == num)
                    return true;
            return false;
        }
        //Looks at collumn
        bool UsedInCol(int[,] matrix, int y, int num)
        {
            for (int x = 0; x < 9; x++)
                if (matrix[x, y] == num)
                    return true;
            return false;
        }
        //Looks at 3x3 box
        bool UsedInBox(int[,] matrix, int boxStartRow, int boxStartCol, int num)
        {
            for (int x = 0; x < 3; x++)
                for (int y = 0; y < 3; y++)
                    if (matrix[x + boxStartRow, y + boxStartCol] == num)
                        return true;
            return false;
        }
        //Can this number be used
        bool isSafe(int[,] matrix, int x, int y, int num)
        {
            //Check rows collums and the box for the same number
            return !UsedInRow(matrix, x, num) &&
                   !UsedInCol(matrix, y, num) &&
                   !UsedInBox(matrix, x - x % 3, y - y % 3, num);
        }

        #endregion

    }
}
