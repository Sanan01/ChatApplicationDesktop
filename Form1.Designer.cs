namespace ChatAppAssignment1
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
            this.startbutton = new System.Windows.Forms.Button();
            this.connectbutton = new System.Windows.Forms.Button();
            this.sendbutton = new System.Windows.Forms.Button();
            this.sIPtextBox = new System.Windows.Forms.TextBox();
            this.sPorttextBox = new System.Windows.Forms.TextBox();
            this.cPorttextBox = new System.Windows.Forms.TextBox();
            this.cIPtextBox = new System.Windows.Forms.TextBox();
            this.ctextBox = new System.Windows.Forms.TextBox();
            this.sendtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(381, 37);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(119, 31);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click_1);
            // 
            // connectbutton
            // 
            this.connectbutton.Location = new System.Drawing.Point(381, 113);
            this.connectbutton.Name = "connectbutton";
            this.connectbutton.Size = new System.Drawing.Size(119, 31);
            this.connectbutton.TabIndex = 1;
            this.connectbutton.Text = "Connect";
            this.connectbutton.UseVisualStyleBackColor = true;
            this.connectbutton.Click += new System.EventHandler(this.connectbutton_Click_1);
            // 
            // sendbutton
            // 
            this.sendbutton.Location = new System.Drawing.Point(423, 397);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(77, 80);
            this.sendbutton.TabIndex = 2;
            this.sendbutton.Text = "Send";
            this.sendbutton.UseVisualStyleBackColor = true;
            this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click);
            // 
            // sIPtextBox
            // 
            this.sIPtextBox.Location = new System.Drawing.Point(12, 37);
            this.sIPtextBox.Name = "sIPtextBox";
            this.sIPtextBox.Size = new System.Drawing.Size(202, 31);
            this.sIPtextBox.TabIndex = 3;
            // 
            // sPorttextBox
            // 
            this.sPorttextBox.Location = new System.Drawing.Point(248, 37);
            this.sPorttextBox.Name = "sPorttextBox";
            this.sPorttextBox.Size = new System.Drawing.Size(78, 31);
            this.sPorttextBox.TabIndex = 4;
            // 
            // cPorttextBox
            // 
            this.cPorttextBox.Location = new System.Drawing.Point(248, 117);
            this.cPorttextBox.Name = "cPorttextBox";
            this.cPorttextBox.Size = new System.Drawing.Size(78, 31);
            this.cPorttextBox.TabIndex = 6;
            // 
            // cIPtextBox
            // 
            this.cIPtextBox.Location = new System.Drawing.Point(12, 113);
            this.cIPtextBox.Name = "cIPtextBox";
            this.cIPtextBox.Size = new System.Drawing.Size(202, 31);
            this.cIPtextBox.TabIndex = 5;
            // 
            // ctextBox
            // 
            this.ctextBox.Location = new System.Drawing.Point(14, 175);
            this.ctextBox.Multiline = true;
            this.ctextBox.Name = "ctextBox";
            this.ctextBox.Size = new System.Drawing.Size(486, 182);
            this.ctextBox.TabIndex = 7;
            // 
            // sendtextBox
            // 
            this.sendtextBox.Location = new System.Drawing.Point(12, 397);
            this.sendtextBox.Multiline = true;
            this.sendtextBox.Name = "sendtextBox";
            this.sendtextBox.Size = new System.Drawing.Size(402, 80);
            this.sendtextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Server IP Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Server Port Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Client IP Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Client Port Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Conversation";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Message";
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            // 
            // backgroundWorker4
            // 
            this.backgroundWorker4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker4_DoWork);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(511, 487);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sendtextBox);
            this.Controls.Add(this.ctextBox);
            this.Controls.Add(this.cPorttextBox);
            this.Controls.Add(this.cIPtextBox);
            this.Controls.Add(this.sPorttextBox);
            this.Controls.Add(this.sIPtextBox);
            this.Controls.Add(this.sendbutton);
            this.Controls.Add(this.connectbutton);
            this.Controls.Add(this.startbutton);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button connectbutton;
        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.TextBox sIPtextBox;
        private System.Windows.Forms.TextBox sPorttextBox;
        private System.Windows.Forms.TextBox cPorttextBox;
        private System.Windows.Forms.TextBox cIPtextBox;
        private System.Windows.Forms.TextBox ctextBox;
        private System.Windows.Forms.TextBox sendtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
    }
}

