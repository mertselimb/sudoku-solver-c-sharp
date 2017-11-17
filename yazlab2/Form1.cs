using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
        int[,] sudokuMatrix;
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

            sudokuMatrix = matrix;
            print(0);
        }
        private void print(int select)
        {
            string output="";
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    output += sudokuMatrix[i, j];
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
    }
}
