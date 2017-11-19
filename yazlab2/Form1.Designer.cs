namespace yazlab2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBrowse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnOpenAnswer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.thread2Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.thread3Label = new System.Windows.Forms.Label();
            this.thread1Label = new System.Windows.Forms.Label();
            this.thread4Label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(224, 9);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 222);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "000000000000000000000000000000000000000000000000000000000000000000000000000000000" +
    "";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(118, 9);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 222);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "000000000000000000000000000000000000000000000000000000000000000000000000000000000" +
    "";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(12, 235);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 232);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "000000000000000000000000000000000000000000000000000000000000000000000000000000000" +
    "";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(118, 235);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 232);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "000000000000000000000000000000000000000000000000000000000000000000000000000000000" +
    "";
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(224, 38);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 23);
            this.btnSolve.TabIndex = 5;
            this.btnSolve.Text = "SOLVE";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnOpenAnswer
            // 
            this.btnOpenAnswer.Location = new System.Drawing.Point(224, 414);
            this.btnOpenAnswer.Name = "btnOpenAnswer";
            this.btnOpenAnswer.Size = new System.Drawing.Size(75, 53);
            this.btnOpenAnswer.TabIndex = 6;
            this.btnOpenAnswer.Text = "Open answer steps";
            this.btnOpenAnswer.UseVisualStyleBackColor = true;
            this.btnOpenAnswer.Click += new System.EventHandler(this.btnOpenAnswer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thread 1 süre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thread 3 süre";
            // 
            // thread2Label
            // 
            this.thread2Label.AutoSize = true;
            this.thread2Label.Location = new System.Drawing.Point(224, 132);
            this.thread2Label.Name = "thread2Label";
            this.thread2Label.Size = new System.Drawing.Size(0, 13);
            this.thread2Label.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Thread 2 süre";
            // 
            // thread3Label
            // 
            this.thread3Label.AutoSize = true;
            this.thread3Label.Location = new System.Drawing.Point(224, 176);
            this.thread3Label.Name = "thread3Label";
            this.thread3Label.Size = new System.Drawing.Size(0, 13);
            this.thread3Label.TabIndex = 12;
            // 
            // thread1Label
            // 
            this.thread1Label.AutoSize = true;
            this.thread1Label.Location = new System.Drawing.Point(224, 87);
            this.thread1Label.Name = "thread1Label";
            this.thread1Label.Size = new System.Drawing.Size(0, 13);
            this.thread1Label.TabIndex = 13;
            // 
            // thread4Label
            // 
            this.thread4Label.AutoSize = true;
            this.thread4Label.Location = new System.Drawing.Point(226, 235);
            this.thread4Label.Name = "thread4Label";
            this.thread4Label.Size = new System.Drawing.Size(0, 13);
            this.thread4Label.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(226, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Thread 4 süre";
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(224, 385);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(75, 23);
            this.btnTime.TabIndex = 16;
            this.btnTime.Text = "Write time";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 479);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.thread4Label);
            this.Controls.Add(this.thread1Label);
            this.Controls.Add(this.thread3Label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.thread2Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenAnswer);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.Text = "Sudoku solver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnOpenAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label thread2Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label thread3Label;
        private System.Windows.Forms.Label thread1Label;
        private System.Windows.Forms.Label thread4Label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTime;
    }
}

