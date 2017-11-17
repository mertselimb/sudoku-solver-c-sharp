using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace yazlab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] sudokuMatrix1;
        int[,] sudokuMatrix2;
        int[,] sudokuMatrix3;
        int[,] sudokuMatrix4;
        Thread th1;
        Thread th2;
        Thread th3;
        Thread th4;
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
            int data=0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    while((int)Char.GetNumericValue(array[index])==-1)
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
            print(0 , sudokuMatrix1);
        }
        private void print(int select , int[,] matrix)
        {
            string output="";
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    output += matrix[i, j];
                }
            }
            if (select==0)
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

        private void btnSolve_Click(object sender, EventArgs e)
        {
            th1 = new Thread(solver1);
            th1.Start();
            th2 = new Thread(solver2);
            th2.Start();
            th3 = new Thread(solver3);
            th3.Start();
            th4 = new Thread(solver4);
            th4.Start();
        }
        private void solver1()
        {
            MessageBox.Show("asdas");
        }
        private void solver2()
        {

        }
        private void solver3()
        {

        }
        private void solver4()
        {

        }
    }
}
