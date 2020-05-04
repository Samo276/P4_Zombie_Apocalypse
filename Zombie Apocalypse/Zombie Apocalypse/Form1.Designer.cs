namespace Zombie_Apocalypse
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
            this.Plansza = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.number_of_humans_textBox = new System.Windows.Forms.TextBox();
            this.number_of_zombie_textBox = new System.Windows.Forms.TextBox();
            this.number_of_soldier_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Plansza
            // 
            this.Plansza.BackColor = System.Drawing.SystemColors.Info;
            this.Plansza.Location = new System.Drawing.Point(25, 25);
            this.Plansza.Name = "Plansza";
            this.Plansza.Size = new System.Drawing.Size(250, 250);
            this.Plansza.TabIndex = 0;
            this.Plansza.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NUMBER OF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Humans";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Zombie";
            //this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Soldiers";
            // 
            // number_of_humans_textBox
            // 
            this.number_of_humans_textBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.number_of_humans_textBox.Location = new System.Drawing.Point(345, 41);
            this.number_of_humans_textBox.Name = "number_of_humans_textBox";
            this.number_of_humans_textBox.Size = new System.Drawing.Size(40, 20);
            this.number_of_humans_textBox.TabIndex = 5;
            // 
            // number_of_zombie_textBox
            // 
            this.number_of_zombie_textBox.Location = new System.Drawing.Point(345, 67);
            this.number_of_zombie_textBox.Name = "number_of_zombie_textBox";
            this.number_of_zombie_textBox.Size = new System.Drawing.Size(40, 20);
            this.number_of_zombie_textBox.TabIndex = 6;
            // 
            // number_of_soldier_textBox
            // 
            this.number_of_soldier_textBox.Location = new System.Drawing.Point(345, 93);
            this.number_of_soldier_textBox.Name = "number_of_soldier_textBox";
            this.number_of_soldier_textBox.Size = new System.Drawing.Size(40, 20);
            this.number_of_soldier_textBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Location = new System.Drawing.Point(303, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 140);
            this.button1.TabIndex = 8;
            this.button1.Text = "   Next Turn     ->";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Begin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 351);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.number_of_soldier_textBox);
            this.Controls.Add(this.number_of_zombie_textBox);
            this.Controls.Add(this.number_of_humans_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Plansza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Plansza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox number_of_humans_textBox;
        private System.Windows.Forms.TextBox number_of_zombie_textBox;
        private System.Windows.Forms.TextBox number_of_soldier_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

