using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        bool stopSwitch = false;
        Thread th1;
        Thread th2;
        Thread th3;
        Thread th4;
        String answer1;
        String answer2;
        String answer3;
        String answer4;
        int step1=0;
        int step2=0;
        int step3=0;
        int step4=0;
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
            if (sudokuMatrix1==null)
            {
                MessageBox.Show("You need to open a sudoku first!");
                return;
            }
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
        private void btnOpenAnswer_Click(object sender, EventArgs e)
        {

            Process.Start(@"c:\answer1.txt");
            Process.Start(@"c:\answer2.txt");
            Process.Start(@"c:\answer3.txt");
            Process.Start(@"c:\answer4.txt");
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
            Solve1(sudokuMatrix1);
            System.IO.File.WriteAllText(@"C:\answer1.txt", answer1);
        }
        private void solver2()
        {
            Solve2(sudokuMatrix2);
            System.IO.File.WriteAllText(@"C:\answer2.txt", answer2);
        }
        private void solver3()
        {
            Solve3(sudokuMatrix3);
            System.IO.File.WriteAllText(@"C:\answer3.txt", answer3);
        }
        private void solver4()
        {
            Solve4(sudokuMatrix4);
            System.IO.File.WriteAllText(@"C:\answer4.txt", answer4);
        }
        #endregion
        #region Solve sudoku
        private bool IsEmpty(int input)
        {
            bool answer = false;
            if (input == 0)
            {
                answer = true;
            }
            return answer;
        }
        private bool Solve1(int[,] matrix)
        {
            if (stopSwitch)
            {
                //answer1 += ++step1 + ") Stop switch is initated." + Environment.NewLine;
                return false;
            }
            int x = 0;
            int y = 0;
            if (IsFull1(matrix, ref x, ref y))
            {
                answer1 += ++step1 + ") Sudoku is full" + Environment.NewLine;
                stopSwitch = true;
                return true;
            }
            answer1 +=++step1 + ") " + x + "'x " + y + "'y is being controlled ." + Environment.NewLine;
            for (int num = 1; num <= 9; num++)
            {
                if (IsSafe(matrix, x, y, num))
                {
                    matrix[x, y] = num;
                    answer1 += ++step1 + ") " + x + "'x " + y + "'y is replaced with " + num + Environment.NewLine;
                    if (Solve1(matrix))
                        return true;

                    matrix[x, y] = 0;
                }
            }
            answer1 += ++step1 + ") " + " No further solution program will go back or end the process." + Environment.NewLine;
            return false;
        }
        private bool Solve2(int[,] matrix)
        {
            if (stopSwitch)
            {
                //answer2 += ++step2 + ") Stop switch is initated." + Environment.NewLine;
                return false;
            }
            int x = 0;
            int y = 0;
            if (IsFull2(matrix, ref x, ref y))
            {
                stopSwitch = true;
                answer2 += ++step2 + ") Sudoku is full" + Environment.NewLine;
                return true;
            }
            answer2 += ++step2 + ") " + x + "'x " + y + "'y is being controlled ." + Environment.NewLine;
            for (int num = 1; num <= 9; num++)
            {
                if (IsSafe(matrix, x, y, num))
                {
                    matrix[x, y] = num;
                    answer2 += ++step2 + ") " + x + "'x " + y + "'y is replaced with " + num + Environment.NewLine;
                    if (Solve2(matrix))
                        return true;

                    matrix[x, y] = 0;
                }
            }
            answer2 += ++step2 + ") " + " No further solution program will go back or end the process." + Environment.NewLine;
            return false;
        }
        private bool Solve3(int[,] matrix)
        {
            if (stopSwitch)
            {
                //answer3 += ++step3 + ") Stop switch is initated." + Environment.NewLine;
                return false;
            }
            int x = 0;
            int y = 0;
            if (IsFull3(matrix, ref x, ref y))
            {
                answer3 += ++step3 + ") Sudoku is full" + Environment.NewLine;
                stopSwitch = true;
                return true;
            }
            answer3 += ++step3 + ") " + x + "'x " + y + "'y is being controlled ." + Environment.NewLine;
            for (int num = 1; num <= 9; num++)
            {
                if (IsSafe(matrix, x, y, num))
                {
                    matrix[x, y] = num;
                    answer3 += ++step3 + ") " + x + "'x " + y + "'y is replaced with " + num + Environment.NewLine;
                    if (Solve3(matrix))
                        return true;

                    matrix[x, y] = 0;
                }
            }
            answer3 += ++step3 + ") " + " No further solution program will go back or end the process." + Environment.NewLine;
            return false;
        }
        private bool Solve4(int[,] matrix)
        {
            if (stopSwitch)
            {
                //answer4 += ++step4 + ") Stop switch is initated." + Environment.NewLine;
                return false;
            }
            int x = 0;
            int y = 0;
            if (IsFull4(matrix, ref x, ref y))
            {
                answer4 += ++step4 + ") Sudoku is full" + Environment.NewLine;
                stopSwitch = true;
                return true;
            }
            answer4 += ++step4 + ") " + x + "'x " + y + "'y is being controlled ." + Environment.NewLine;
            for (int num = 1; num <= 9; num++)
            {
                if (IsSafe(matrix, x, y, num))
                {
                    matrix[x, y] = num;
                    answer4 += ++step4 + ") " + x + "'x " + y + "'y is replaced with " + num + Environment.NewLine;
                    if (Solve4(matrix))
                        return true;

                    matrix[x, y] = 0;
                }
            }
            answer4 += ++step4 + ") " + " No further solution program will go back or end the process." + Environment.NewLine;
            return false;
        }
        bool IsFull1(int[,] matrix, ref int x, ref int y)
        {
            for (x = 0; x < 9; x++)
                for (y = 0; y < 9; y++)
                    if (matrix[x, y] == 0)
                        return false;
            return true;
        } //Is there space for more calculations in sudoku
        bool IsFull2(int[,] matrix, ref int x, ref int y)
        {
            for (x = 8; x > 0; x--)
                for (y = 8; y > 0; y--)
                    if (matrix[x, y] == 0)
                        return false;
            return true;
        } //Is there space for more calculations in sudoku
        bool IsFull3(int[,] matrix, ref int x, ref int y)
        {
            for (x = 8; x > 0; x--)
                for (y = 0; y < 9; y++)
                    if (matrix[x, y] == 0)
                        return false;
            return true;
        } //Is there space for more calculations in sudoku
        bool IsFull4(int[,] matrix, ref int x, ref int y)
        {
            for (x = 0; x < 9; x++)
                for (y = 8; y > 0; y--)
                    if (matrix[x, y] == 0)
                        return false;
            return true;
        } //Is there space for more calculations in sudoku
        bool UsedInRow(int[,] matrix, int x, int num)
        {
            for (int y = 0; y < 9; y++)
                if (matrix[x, y] == num)
                    return true;
            return false;
        } //Looks at x
        bool UsedInCol(int[,] matrix, int y, int num)
        {
            for (int x = 0; x < 9; x++)
                if (matrix[x, y] == num)
                    return true;
            return false;
        }//Looks at collumn
        bool UsedInBox(int[,] matrix, int boxStartRow, int boxStartCol, int num)
        {
            for (int x = 0; x < 3; x++)
                for (int y = 0; y < 3; y++)
                    if (matrix[x + boxStartRow, y + boxStartCol] == num)
                        return true;
            return false;
        }//Looks at 3x3 box
        bool IsSafe(int[,] matrix, int x, int y, int num)
        {
            //Check rows collums and the box for the same number
            return !UsedInRow(matrix, x, num) &&
                   !UsedInCol(matrix, y, num) &&
                   !UsedInBox(matrix, x - x % 3, y - y % 3, num);
        }//Can this number be used

        #endregion
    }
}
