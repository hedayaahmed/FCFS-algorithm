namespace FCFS
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FCFS_Button = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Queue = new System.Windows.Forms.Label();
            this.Array = new System.Windows.Forms.TextBox();
            this.Head_Starts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RUN_Button = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.FCFS_Button);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(90, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 70);
            this.panel1.TabIndex = 8;
            // 
            // FCFS_Button
            // 
            this.FCFS_Button.AutoSize = true;
            this.FCFS_Button.Checked = true;
            this.FCFS_Button.Location = new System.Drawing.Point(23, 36);
            this.FCFS_Button.Name = "FCFS_Button";
            this.FCFS_Button.Size = new System.Drawing.Size(51, 17);
            this.FCFS_Button.TabIndex = 2;
            this.FCFS_Button.TabStop = true;
            this.FCFS_Button.Text = "FCFS";
            this.FCFS_Button.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Algorithm";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.Queue);
            this.panel2.Controls.Add(this.Array);
            this.panel2.Controls.Add(this.Head_Starts);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 75);
            this.panel2.TabIndex = 9;
            // 
            // Queue
            // 
            this.Queue.AutoSize = true;
            this.Queue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Queue.Location = new System.Drawing.Point(3, 9);
            this.Queue.Name = "Queue";
            this.Queue.Size = new System.Drawing.Size(48, 16);
            this.Queue.TabIndex = 1;
            this.Queue.Text = "Queue";
            // 
            // Array
            // 
            this.Array.Location = new System.Drawing.Point(57, 8);
            this.Array.Multiline = true;
            this.Array.Name = "Array";
            this.Array.Size = new System.Drawing.Size(206, 23);
            this.Array.TabIndex = 0;
            // 
            // Head_Starts
            // 
            this.Head_Starts.Location = new System.Drawing.Point(113, 43);
            this.Head_Starts.Multiline = true;
            this.Head_Starts.Name = "Head_Starts";
            this.Head_Starts.Size = new System.Drawing.Size(63, 23);
            this.Head_Starts.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Head_Starts_at :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.RUN_Button);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(14, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 319);
            this.panel3.TabIndex = 10;
            // 
            // RUN_Button
            // 
            this.RUN_Button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.RUN_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RUN_Button.Location = new System.Drawing.Point(50, 260);
            this.RUN_Button.Name = "RUN_Button";
            this.RUN_Button.Size = new System.Drawing.Size(186, 34);
            this.RUN_Button.TabIndex = 9;
            this.RUN_Button.Text = "RUN";
            this.RUN_Button.UseVisualStyleBackColor = false;
            this.RUN_Button.Click += new System.EventHandler(this.RUN_Button_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SkyBlue;
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(16, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(131, 91);
            this.panel5.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 37);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distance";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Location = new System.Drawing.Point(74, 334);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(165, 124);
            this.panel6.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(314, 478);
            this.panel4.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1300, 502);
            this.Controls.Add(this.panel4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Queue;
        private System.Windows.Forms.TextBox Array;
        private System.Windows.Forms.TextBox Head_Starts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button RUN_Button;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton FCFS_Button;
    }
}

