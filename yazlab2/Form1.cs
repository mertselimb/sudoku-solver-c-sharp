using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;


namespace yazlab2
{
    public partial class Form1 : Form
    {
        #region Definitions//Defines what is needed publicly
        public Form1()
        {
            InitializeComponent();
        }
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();//To print what happens
        int[,] sudokuMatrix1;//Thread matrix
        int[,] sudokuMatrix2;
        int[,] sudokuMatrix3;
        int[,] sudokuMatrix4;
        bool stopSwitch = false;//When one thread ends this will end all
        String answer1;//Answers to write in txt files 
        String answer2;
        String answer3;
        String answer4;
        int step1=0;//Step counter
        int step2=0;
        int step3=0;
        int step4=0;
        string timeUsed1="";
        string timeUsed2="";
        string timeUsed3="";
        string timeUsed4="";
        #endregion
        #region Clicks//Button click functions needed for form ui
        private void btnBrowse_Click(object sender, EventArgs e)//When browse clicked
        {

            string sudokuSource = File.ReadAllText(@"C:\sudoku.txt");//Read file
            char[] array = sudokuSource.ToCharArray();//To char array becouse you can not change strings 
            for (int i = 0; i < sudokuSource.Length; i++)
            {
                if (String.Equals('*', sudokuSource[i]))
                {
                    array[i] = '0';//Getting rid of *'s for int matrix
                }
            }

            int[,] matrix = new int[9, 9];
            int index = 0;//index of char array
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    while ((int)Char.GetNumericValue(array[index]) == -1)//We don't need blank spaces in our matrix (like line endings and empty sudoku spaces)
                    {
                        index++;
                    };
                    matrix[i, j] = (int)Char.GetNumericValue(array[index]);

                    if (array.Length <= index)//For overflow from last step
                    {
                        break;
                    }
                    index++;
                }
                if (array.Length <= index)//For overflow from last step
                {
                    break;
                }
            }
            sudokuMatrix1 = matrix;//Data transferred to public matrix
            sudokuMatrix2 = matrix;
            sudokuMatrix3 = matrix;
            sudokuMatrix4 = matrix;
            print(0, sudokuMatrix1);//Printed to textboxes
        }
        private void btnSolve_Click(object sender, EventArgs e)//Solve the sudoku
        {
            if (sudokuMatrix1==null)//If user didn't browse before i shouldn't work
            {
                MessageBox.Show("You need to open a sudoku first!");
                return;
            }
            myTimer.Tick += new EventHandler(printAll);//Timer for showing what happens in solve function
            myTimer.Interval = 1;
            myTimer.Start();
            Thread th1 = new Thread(solver1);//Threads are started with their own solve function
            th1.Start();
            Thread th2 = new Thread(solver2);
            th2.Start();
            Thread th3 = new Thread(solver3);
            th3.Start();
            Thread th4 = new Thread(solver4);
            th4.Start();
        }
        /*private void btnPrint_Click(object sender, EventArgs e)//Written before but not used prints all matrixs
        {
            print(1, sudokuMatrix1);
            print(2, sudokuMatrix2);
            print(3, sudokuMatrix3);
            print(4, sudokuMatrix4);
        }*/
        private void btnOpenAnswer_Click(object sender, EventArgs e)//Opens the file that shows answer steps 
        {

            Process.Start(@"c:\answer1.txt");//Open the file at this location with default app
            Process.Start(@"c:\answer2.txt");
            Process.Start(@"c:\answer3.txt");
            Process.Start(@"c:\answer4.txt");
        }
        #endregion//
        #region Print//Print functions for textbox responsiveness
        private void print(int select, int[,] matrix)//Print whatever needed
        {
            string output = "";
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)//Matrix to string
                {
                    output += matrix[i, j];
                }
            }
            if (select == 0)//0 means write all
            {
                textBox1.Text = output;//Textboxes getting matrrix data in string form
                textBox2.Text = output;
                textBox3.Text = output;
                textBox4.Text = output;
            }
            if (select == 1)//Only textbox1 gets data
            {
                textBox1.Text = output;
            }
            if (select == 2)//Only textbox2 gets data
            {
                textBox2.Text = output;
            }
            if (select == 3)//Only textbox3 gets data
            {
                textBox3.Text = output;
            }
            if (select == 4)//Only textbox4 gets data
            {
                textBox4.Text = output;
            }
        }
        private void printAll(Object myObject, EventArgs myEventArgs)//Pritns all for timer function
        {
            
            print(1, sudokuMatrix1);//Print selected matrix to It's textbox
            print(2, sudokuMatrix2);
            print(3, sudokuMatrix3);
            print(4, sudokuMatrix4);
        }
        #endregion
        #region Threads//Thread functions
        private void solver1()//Function to be called for thread starter
        {
            Stopwatch stopWatch1 = new Stopwatch();
            stopWatch1.Start();
            Solve1(sudokuMatrix1);//Solves its own matrix
            System.IO.File.WriteAllText(@"C:\answer1.txt", answer1);//Write answer
            stopWatch1.Stop();
            timeUsed1 = stopWatch1.ElapsedMilliseconds.ToString();
        }
        private void solver2()//Function to be called for thread starter
        {
            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            Solve2(sudokuMatrix2);//Solves its own matrix
            System.IO.File.WriteAllText(@"C:\answer2.txt", answer2);//Write answer
            stopWatch2.Stop();
            timeUsed2 = stopWatch2.ElapsedMilliseconds.ToString();
        }
        private void solver3()//Function to be called for thread starter
        {
            Stopwatch stopWatch3 = new Stopwatch();
            stopWatch3.Start();
            Solve3(sudokuMatrix3);//Solves its own matrix
            System.IO.File.WriteAllText(@"C:\answer3.txt", answer3);//Write answer
            stopWatch3.Stop();
            timeUsed3 = stopWatch3.ElapsedMilliseconds.ToString();
        }
        private void solver4()//Function to be called for thread starter
        {
            Stopwatch stopWatch4 = new Stopwatch();
            stopWatch4.Start();
            Solve4(sudokuMatrix4);//Solves its own matrix
            System.IO.File.WriteAllText(@"C:\answer4.txt", answer4);//Write answer
            stopWatch4.Stop();
            timeUsed4 = stopWatch4.ElapsedMilliseconds.ToString();
        }
        #endregion
        #region Solve sudoku//Functions for solving sudoku
        /*private bool IsEmpty(int input)//Looking for is the space that sent is empty(not used)
        {
            bool answer = false;
            if (input == 0)
            {
                answer = true;
            }
            return answer;
        }*/
        private bool Solve1(int[,] matrix)//Real solver function
        {
            if (stopSwitch)//If any other thread solves sudoku this will stop all others
            {
                //answer1 += ++step1 + ") Stop switch is initated." + Environment.NewLine;
                return false;
            }
            int x = 0;//Sudoku row to used
            int y = 0;//Sudoku collumn to used
            if (IsFull1(matrix, ref x, ref y))//Is sudoku finished?Is there any space to work on?
            {
                answer1 += ++step1 + ") Sudoku is full" + Environment.NewLine;//Step logs
                stopSwitch = true;
                return true;
            }
            answer1 +=++step1 + ") " + x + "'x " + y + "'y is being controlled ." + Environment.NewLine;
            for (int num = 1; num <= 9; num++)//Tries numbers from 1 to 9 calls function for all of them
            {
                if (IsSafe(matrix, x, y, num))//Looks for a problem with the current number
                {
                    matrix[x, y] = num;//If there is non then uses it
                    answer1 += ++step1 + ") " + x + "'x " + y + "'y is replaced with " + num + Environment.NewLine;//Step logs
                    if (Solve1(matrix))//Recursively tries all in called functions
                        return true;

                    matrix[x, y] = 0;//Program made a mistake it goes back(Becouse it doesn't returned from the if up there)
                }
            }
            answer1 += ++step1 + ") " + " No further solution program will go back or end the process." + Environment.NewLine;//Step logs
            return false;//We came a wrong way go back to function that called you or there is no solution
        }
        private bool Solve2(int[,] matrix)//Real solver function
        {
            if (stopSwitch)//If any other thread solves sudoku this will stop all others
            {
                //answer2 += ++step2 + ") Stop switch is initated." + Environment.NewLine;
                return false;
            }
            int x = 0;//Sudoku row to used
            int y = 0;//Sudoku collumn to used
            if (IsFull2(matrix, ref x, ref y))//Is sudoku finished?Is there any space to work on?
            {
                stopSwitch = true;
                answer2 += ++step2 + ") Sudoku is full" + Environment.NewLine;//Step logs
                return true;
            }
            answer2 += ++step2 + ") " + x + "'x " + y + "'y is being controlled ." + Environment.NewLine;//Step logs
            for (int num = 1; num <= 9; num++)//Tries numbers from 1 to 9 calls function for all of them
            {
                if (IsSafe(matrix, x, y, num))//Looks for a problem with the current number
                {
                    matrix[x, y] = num;//If there is non then uses it
                    answer2 += ++step2 + ") " + x + "'x " + y + "'y is replaced with " + num + Environment.NewLine;//Step logs
                    if (Solve2(matrix))//Recursively tries all in called functions
                        return true;

                    matrix[x, y] = 0;//Program made a mistake it goes back(Becouse it doesn't returned from the if up there)
                }
            }
            answer2 += ++step2 + ") " + " No further solution program will go back or end the process." + Environment.NewLine;//Step logs
            return false;//We came a wrong way go back to function that called you or there is no solution
        }
        private bool Solve3(int[,] matrix)//Real solver function
        {
            if (stopSwitch)//If any other thread solves sudoku this will stop all others
            {
                //answer3 += ++step3 + ") Stop switch is initated." + Environment.NewLine;
                return false;
            }
            int x = 0;//Sudoku row to used
            int y = 0;//Sudoku collumn to used
            if (IsFull3(matrix, ref x, ref y))//Is sudoku finished?Is there any space to work on?
            {
                answer3 += ++step3 + ") Sudoku is full" + Environment.NewLine;//Step logs
                stopSwitch = true;
                return true;
            }
            answer3 += ++step3 + ") " + x + "'x " + y + "'y is being controlled ." + Environment.NewLine;//Step logs
            for (int num = 1; num <= 9; num++)//Tries numbers from 1 to 9 calls function for all of them
            {
                if (IsSafe(matrix, x, y, num))//Looks for a problem with the current number
                {
                    matrix[x, y] = num;//If there is non then uses it
                    answer3 += ++step3 + ") " + x + "'x " + y + "'y is replaced with " + num + Environment.NewLine;//Step logs
                    if (Solve3(matrix))//Recursively tries all in called functions
                        return true;

                    matrix[x, y] = 0;//Program made a mistake it goes back(Becouse it doesn't returned from the if up there)
                }
            }
            answer3 += ++step3 + ") " + " No further solution program will go back or end the process." + Environment.NewLine;//Step logs
            return false;//We came a wrong way go back to function that called you or there is no solution
        }
        private bool Solve4(int[,] matrix)//Real solver function
        {
            if (stopSwitch)//If any other thread solves sudoku this will stop all others
            {
                //answer4 += ++step4 + ") Stop switch is initated." + Environment.NewLine;
                return false;
            }
            int x = 0;//Sudoku row to used
            int y = 0;//Sudoku collumn to used
            if (IsFull4(matrix, ref x, ref y))//Is sudoku finished?Is there any space to work on?
            {
                answer4 += ++step4 + ") Sudoku is full" + Environment.NewLine;//Step logs
                stopSwitch = true;
                return true;
            }
            answer4 += ++step4 + ") " + x + "'x " + y + "'y is being controlled ." + Environment.NewLine;//Step logs
            for (int num = 1; num <= 9; num++)//Tries numbers from 1 to 9 calls function for all of them
            {
                if (IsSafe(matrix, x, y, num))//Looks for a problem with the current number
                {
                    matrix[x, y] = num;//If there is non then uses it
                    answer4 += ++step4 + ") " + x + "'x " + y + "'y is replaced with " + num + Environment.NewLine;//Step logs
                    if (Solve4(matrix))//Recursively tries all in called functions
                        return true;

                    matrix[x, y] = 0;//Program made a mistake it goes back(Becouse it doesn't returned from the if up there)
                }
            }
            answer4 += ++step4 + ") " + " No further solution program will go back or end the process." + Environment.NewLine;//Step logs
            return false;//We came a wrong way go back to function that called you or there is no solution
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
            for (x = 8; x >= 0; x--)
                for (y = 8; y >= 0; y--)
                    if (matrix[x, y] == 0)
                        return false;
            return true;
        } //Is there space for more calculations in sudoku
        bool IsFull3(int[,] matrix, ref int x, ref int y)
        {
            for (x = 8; x >= 0; x--)
                for (y = 0; y < 9; y++)
                    if (matrix[x, y] == 0)
                        return false;
            return true;
        } //Is there space for more calculations in sudoku
        bool IsFull4(int[,] matrix, ref int x, ref int y)
        {
            for (x = 0; x < 9; x++)
                for (y = 8; y >= 0; y--)
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

        private void btnTime_Click(object sender, EventArgs e)
        {
            thread1Label.Text = timeUsed1 + " ms";
            thread2Label.Text = timeUsed2 + " ms";
            thread3Label.Text = timeUsed3 + " ms";
            thread4Label.Text = timeUsed4 + " ms";
        }
    }
}
