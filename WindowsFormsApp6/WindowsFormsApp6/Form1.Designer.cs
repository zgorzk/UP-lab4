namespace WindowsFormsApp6
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
            this.Bconnect = new System.Windows.Forms.Button();
            this.Bdisconnect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RTBLogBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BsendFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bconnect
            // 
            this.Bconnect.Location = new System.Drawing.Point(25, 95);
            this.Bconnect.Name = "Bconnect";
            this.Bconnect.Size = new System.Drawing.Size(177, 39);
            this.Bconnect.TabIndex = 0;
            this.Bconnect.Text = "CONNECT: COM1 ";
            this.Bconnect.UseVisualStyleBackColor = true;
            this.Bconnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bdisconnect
            // 
            this.Bdisconnect.Location = new System.Drawing.Point(25, 140);
            this.Bdisconnect.Name = "Bdisconnect";
            this.Bdisconnect.Size = new System.Drawing.Size(177, 39);
            this.Bdisconnect.TabIndex = 1;
            this.Bdisconnect.Text = "DISCONNECT";
            this.Bdisconnect.UseVisualStyleBackColor = true;
            this.Bdisconnect.Click += new System.EventHandler(this.Bdisconnect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "COM1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RTBLogBox
            // 
            this.RTBLogBox.Location = new System.Drawing.Point(215, 209);
            this.RTBLogBox.Name = "RTBLogBox";
            this.RTBLogBox.Size = new System.Drawing.Size(476, 202);
            this.RTBLogBox.TabIndex = 3;
            this.RTBLogBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "KOMENDA HAYES\'A: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(445, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 26);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
            // 
            // BsendFile
            // 
            this.BsendFile.Location = new System.Drawing.Point(289, 111);
            this.BsendFile.Name = "BsendFile";
            this.BsendFile.Size = new System.Drawing.Size(208, 39);
            this.BsendFile.TabIndex = 6;
            this.BsendFile.Text = "send file";
            this.BsendFile.UseVisualStyleBackColor = true;
            this.BsendFile.Click += new System.EventHandler(this.BsendFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BsendFile);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RTBLogBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Bdisconnect);
            this.Controls.Add(this.Bconnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bconnect;
        private System.Windows.Forms.Button Bdisconnect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox RTBLogBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BsendFile;
    }
}

