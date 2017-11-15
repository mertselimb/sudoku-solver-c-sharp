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
                if (String.Equals("*", sudokuSource[i]))
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
                    matrix[i, j] = (int)Char.GetNumericValue(array[index]);
                    index++;
                }
            }

            sudokuMatrix = matrix;
        }
    }
}
